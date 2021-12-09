using Generator.Domain;
using Generator.DomainApi.Services;
using Generator.Extension;
using Generator.Persistence.Adapter;
using Generator.Persistence.Adapter.Common;
using Generator.Persistence.Adapter.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Generator
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private AppSettings AppSettings { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            AppSettings = new AppSettings();
            Configuration.Bind(AppSettings);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddPersistence();

            services.AddDomain();

            services.AddSwaggerOpenAPI(AppSettings);

            services.AddApiVersion();

            services.AddHealthCheck(AppSettings);

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory log)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                SeedTestingData(app);
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseSwaggerConfig();

            app.UseHealthCheck();

            log.AddSerilog();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void SeedTestingData(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Deals.AddRange(ApplicationDbContextFactory.GetDeals());
                context.SaveChanges();
            }
        }
    }
}

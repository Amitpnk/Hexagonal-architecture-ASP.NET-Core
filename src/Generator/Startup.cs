using Generator.Domain;
using Generator.DomainApi.Services;
using Generator.Extension;
using Generator.Persistence.Adapter;
using Generator.Persistence.Adapter.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using System;

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

            services.AddHealthCheck();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseSwaggerConfig();

            app.UseHealthCheck();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

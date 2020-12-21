using Microsoft.AspNetCore.Builder;

namespace Generator.Extension
{
    public static class ConfigureContainer
    {
        public static void UseSwaggerConfig(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint("/swagger/OpenAPISpecification/swagger.json", "Hexagonal Architecture API");
                setupAction.RoutePrefix = "OpenAPI";
            });
        }
    }
}

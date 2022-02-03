using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace adduo.elephant.api.configurations
{
    public static class ApiVersionConfiguration
    {
        public static void AddApiVersion(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true; ;

            });
        }
    }
}

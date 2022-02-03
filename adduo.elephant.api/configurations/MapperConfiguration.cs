using Microsoft.Extensions.DependencyInjection;
using System;

namespace adduo.elephant.api.configurations
{
    public static class MapperConfiguration
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}

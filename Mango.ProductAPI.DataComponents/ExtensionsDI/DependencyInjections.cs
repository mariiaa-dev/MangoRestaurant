using Mango.ProductAPI.DataComponents.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace Mango.ProductAPI.DataComponents.ExtensionsDI
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDataComponents(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DomainToDTO_Profile));
            services.AddAutoMapper(typeof(DTO_ToDomainProfile));

            return services;
        }
    }
}

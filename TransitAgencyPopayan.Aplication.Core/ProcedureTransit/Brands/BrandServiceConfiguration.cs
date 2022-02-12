using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Brands;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Brands
{
    public static class BrandServiceConfiguration
    {
        public static void ConfigureBrandService(this IServiceCollection services)
        {
            services.TryAddScoped<IBrandService, BrandService>();
            services.ConfigureBrandRepository();
        }
    }
}
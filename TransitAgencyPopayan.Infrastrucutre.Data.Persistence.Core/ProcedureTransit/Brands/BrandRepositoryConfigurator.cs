using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Brands;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Brands
{
    public static class BrandRepositoryConfigurator
    {
        public static void ConfigureBrandRepository(this IServiceCollection services) =>
            services.TryAddScoped<IBrandRepository, BrandRepository>();
    }
}
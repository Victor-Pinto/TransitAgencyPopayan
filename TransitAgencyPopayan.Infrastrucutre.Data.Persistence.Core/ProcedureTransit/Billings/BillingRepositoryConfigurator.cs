using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Billings;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Billings
{
    public static class BillingRepositoryConfigurator
    {
        public static void ConfigureBillingRepository(this IServiceCollection services) =>
            services.TryAddScoped<IBillingRepository, BillingRepository>();
    }
}
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.ProcedureBillings;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.ProcedureBillings
{
    public static class ProcedureBillingRepositoryConfigurator
    {
        public static void ConfigureProcedureBillingRepository(this IServiceCollection services) =>
            services.TryAddScoped<IProcedureBillingRepository, ProcedureBillingRepository>();
    }
}
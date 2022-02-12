using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.ProcedureBillings;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.ProcedureBillings
{
    public static class ProcedureBillingServiceConfiguration
    {
        public static void ConfigureProcedureBillingService(this IServiceCollection services)
        {
            services.TryAddScoped<IProcedureBillingService, ProcedureBillingService>();
            services.ConfigureProcedureBillingRepository();
        }
    }
}
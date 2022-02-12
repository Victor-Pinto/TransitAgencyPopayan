using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Billings;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Billings
{
    public static class BillingServiceConfiguration
    {
        public static void ConfigureBillingService(this IServiceCollection services)
        {
            services.TryAddScoped<IBillingService, BillingService>();
            services.ConfigureBillingRepository();
        }
    }
}
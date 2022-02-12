using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Procedures;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Procedures
{
    public static class ProcedureServiceConfiguration
    {
        public static void ConfigureProcedureService(this IServiceCollection services)
        {
            services.TryAddScoped<IProcedureService, ProcedureService>();
            services.ConfigureProcedureRepository();
        }
    }
}
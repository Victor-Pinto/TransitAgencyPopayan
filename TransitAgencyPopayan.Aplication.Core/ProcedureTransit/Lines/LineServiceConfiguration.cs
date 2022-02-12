using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Lines;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Lines
{
    public static class LineServiceConfiguration
    {
        public static void ConfigureLineService(this IServiceCollection services)
        {
            services.TryAddScoped<ILineService, LineService>();
            services.ConfigureLineRepository();
        }
    }
}
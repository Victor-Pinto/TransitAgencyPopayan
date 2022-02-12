using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Lines;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Lines
{
    public static class LineRepositoryConfigurator
    {
        public static void ConfigureLineRepository(this IServiceCollection services) =>
            services.TryAddScoped<ILineRepository, LineRepository>();
    }
}
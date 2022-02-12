using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Procedures;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Procedures
{
    public static class ProcedureRepositoryConfigurator
    {
        public static void ConfigureProcedureRepository(this IServiceCollection services) =>
            services.TryAddScoped<IProcedureRepository, ProcedureRepository>();
    }
}
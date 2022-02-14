using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.ProcedureTransit
{
    public static class ProcedureContextConfiguration
    {
        public static void ConfigureProcedureContextDb(this IServiceCollection services, string procedureConnection)
        {
            services.TryAddScoped<IProcedureContextDb, ProcedureContextDb>();
            services.AddDbContext<ProcedureContextDb>(x => x.UseSqlServer(procedureConnection));
        }
    }
}

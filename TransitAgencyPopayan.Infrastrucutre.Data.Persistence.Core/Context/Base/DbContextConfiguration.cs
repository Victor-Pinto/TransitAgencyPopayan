using Microsoft.Extensions.DependencyInjection;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.ProcedureTransit;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.Base
{
    public static class DbContextConfiguration
    {
        public static void ConfigureDbContext(this IServiceCollection services, string sqlConnection) =>
            services.ConfigureProcedureContextDb(sqlConnection);
    }
}
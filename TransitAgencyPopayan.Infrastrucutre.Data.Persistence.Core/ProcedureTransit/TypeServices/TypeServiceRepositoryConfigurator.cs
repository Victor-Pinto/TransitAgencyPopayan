using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.TypeServices;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.TypeServices
{
    public static class TypeServiceRepositoryConfigurator
    {
        public static void ConfigureTypeServiceRepository(this IServiceCollection services) =>
            services.TryAddScoped<ITypeServiceRepository, TypeServiceRepository>();
    }
}
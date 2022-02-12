using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.TypeServices;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.TypeServices
{
    public static class TypeServiceServiceConfiguration
    {
        public static void ConfigureTypeServiceService(this IServiceCollection services)
        {
            services.TryAddScoped<ITypeServiceService, TypeServiceService>();
            services.ConfigureTypeServiceRepository();
        }
    }
}
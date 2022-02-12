using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Owners;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Owners
{
    public static class OwnerServiceConfiguration
    {
        public static void ConfigureOwnerService(this IServiceCollection services)
        {
            services.TryAddScoped<IOwnerService, OwnerService>();
            services.ConfigureOwnerRepository();
        }
    }
}
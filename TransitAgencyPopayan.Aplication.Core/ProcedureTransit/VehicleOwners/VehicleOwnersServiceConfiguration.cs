using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.VehicleOwners;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.VehicleOwners
{
    public static class VehicleOwnerServiceConfiguration
    {
        public static void ConfigureVehicleOwnerService(this IServiceCollection services)
        {
            services.TryAddScoped<IVehicleOwnerService, VehicleOwnerService>();
            services.ConfigureVehicleOwnerRepository();
        }
    }
}
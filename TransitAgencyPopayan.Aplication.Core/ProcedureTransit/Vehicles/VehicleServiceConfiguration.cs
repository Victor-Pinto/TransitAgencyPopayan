using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Vehicles;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Vehicles
{
    public static class VehicleServiceConfiguration
    {
        public static void ConfigureVehicleService(this IServiceCollection services)
        {
            services.TryAddScoped<IVehicleService, VehicleService>();
            services.ConfigureVehiculeRepository();
        }
    }
}
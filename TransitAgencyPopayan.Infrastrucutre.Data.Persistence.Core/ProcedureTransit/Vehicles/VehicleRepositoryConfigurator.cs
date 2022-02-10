using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Vehicles;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Vehicles
{
    public static class VehicleRepositoryConfigurator
    {
        public static void ConfigureVehiculeRepository(this IServiceCollection services) =>
            services.TryAddScoped<IVehicleRepository, VehicleRepository>();
    }
}
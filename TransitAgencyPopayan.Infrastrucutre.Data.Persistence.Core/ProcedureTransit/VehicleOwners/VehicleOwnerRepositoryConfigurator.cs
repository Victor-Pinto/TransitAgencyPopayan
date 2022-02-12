using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleOwners;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.VehicleOwners
{
    public static class VehicleOwnerRepositoryConfigurator
    {
        public static void ConfigureVehicleOwnerRepository(this IServiceCollection services) =>
            services.TryAddScoped<IVehicleOwnerRepository, VehicleOwnerRepository>();
    }
}
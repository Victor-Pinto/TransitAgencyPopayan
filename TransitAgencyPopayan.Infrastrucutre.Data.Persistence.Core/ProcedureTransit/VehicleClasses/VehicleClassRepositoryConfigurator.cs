using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleClasses;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.VehicleClasses
{
    public static class VehicleClassRepositoryConfigurator
    {
        public static void ConfigureVehicleClassRepository(this IServiceCollection services) =>
            services.TryAddScoped<IVehicleClassRepository, VehicleClassRepository>();
    }
}
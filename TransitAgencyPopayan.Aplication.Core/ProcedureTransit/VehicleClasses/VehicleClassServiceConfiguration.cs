using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.VehicleClasses;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.VehicleClasses
{
    public static class VehicleClassServiceConfiguration
    {
        public static void ConfigureVehicleClassService(this IServiceCollection services)
        {
            services.TryAddScoped<IVehicleClassService, VehicleClassService>();
            services.ConfigureVehicleClassRepository();
        }
    }
}
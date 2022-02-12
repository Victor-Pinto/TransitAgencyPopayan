using Microsoft.Extensions.DependencyInjection;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Billings;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Vehicles;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit
{
    public static class ProcedureTransitConfigurator
    {
        public static void ConfigureProcedureTransitServices(this IServiceCollection services)
        {
            services.ConfigureVehicleService();
            services.ConfigureBillingService();
            //Todo:Victor, completar cada llamado de los configuradores de los servicios
            //Configurator of billing
            // Configurator of line
            // Configurator of proceduce
        }
    }
}
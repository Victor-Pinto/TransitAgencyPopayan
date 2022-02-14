using Microsoft.Extensions.DependencyInjection;
using TransitAgencyPopayan.Aplication.Core.Mapper.Configuration;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Billings;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Brands;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Lines;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Owners;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.ProcedureBillings;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Procedures;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.TypeServices;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.VehicleClasses;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.VehicleOwners;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Vehicles;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit
{
    public static class ProcedureTransitConfigurator
    {
        public static void ConfigureProcedureTransitServices(this IServiceCollection services)
        {
            services.ConfigureBillingService();
            services.ConfigureBrandService();
            services.ConfigureLineService();
            services.ConfigureOwnerService();
            services.ConfigureProcedureBillingService();
            services.ConfigureProcedureService();
            services.ConfigureTypeServiceService();
            services.ConfigureVehicleClassService();
            services.ConfigureVehicleOwnerService();
            services.ConfigureVehicleService();

            services.ConfigureMapper();
        }
    }
}
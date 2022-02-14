using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Vehicles;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.ProcedureTransit;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Vehicles
{
    public class VehicleRepository : RepositoryBase<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(IProcedureContextDb unitOfWork) : base(unitOfWork) { }
    }
}
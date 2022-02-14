using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleClasses;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.ProcedureTransit;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.VehicleClasses
{
    public class VehicleClassRepository : RepositoryBase<VehicleClass>, IVehicleClassRepository
    {
        public VehicleClassRepository(IProcedureContextDb unitOfWork) : base(unitOfWork) { }
    }
}
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleClasses;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.VehicleClasses
{
    public class VehicleClassRepository : RepositoryBase<VehicleClass>, IVehicleClassRepository
    {
        public VehicleClassRepository(IContextDb dbContext) : base(dbContext) { }
    }
}
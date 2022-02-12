using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleOwners;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.VehicleOwners
{
    public class VehicleOwnerRepository : RepositoryBase<VehicleOwner>, IVehicleOwnerRepository
    {
        public VehicleOwnerRepository(IContextDb dbContext) : base(dbContext) { }
    }
}
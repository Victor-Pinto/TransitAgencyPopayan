using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleOwners;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.ProcedureTransit;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.VehicleOwners
{
    public class VehicleOwnerRepository : RepositoryBase<VehicleOwner>, IVehicleOwnerRepository
    {
        public VehicleOwnerRepository(IProcedureContextDb unitOfWork) : base(unitOfWork) { }
    }
}
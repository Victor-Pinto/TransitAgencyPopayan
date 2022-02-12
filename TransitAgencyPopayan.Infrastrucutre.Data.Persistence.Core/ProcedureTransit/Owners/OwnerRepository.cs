using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Owners;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Owners
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(IContextDb dbContext) : base(dbContext) { }
    }
}
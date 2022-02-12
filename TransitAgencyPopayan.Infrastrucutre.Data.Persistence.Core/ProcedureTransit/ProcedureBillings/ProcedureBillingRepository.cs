using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.ProcedureBillings;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.ProcedureBillings
{
    public class ProcedureBillingRepository : RepositoryBase<ProcedureBilling>, IProcedureBillingRepository
    {
        public ProcedureBillingRepository(IContextDb dbContext) : base(dbContext) { }
    }
}
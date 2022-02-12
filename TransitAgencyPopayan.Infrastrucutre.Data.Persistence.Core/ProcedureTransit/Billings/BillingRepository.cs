using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Billings;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Billings
{
    public class BillingRepository : RepositoryBase<Billing>, IBillingRepository
    {
        public BillingRepository(IContextDb dbContext) : base(dbContext) { }
    }
}
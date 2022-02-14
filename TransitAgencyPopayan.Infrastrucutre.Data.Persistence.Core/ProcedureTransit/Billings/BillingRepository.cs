using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Billings;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.ProcedureTransit;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Billings
{
    public class BillingRepository : RepositoryBase<Billing>, IBillingRepository
    {
        public BillingRepository(IProcedureContextDb unitOfWork) : base(unitOfWork) { }
    }
}
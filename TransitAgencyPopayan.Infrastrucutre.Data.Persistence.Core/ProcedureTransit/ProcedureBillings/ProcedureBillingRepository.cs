using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.ProcedureBillings;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.ProcedureTransit;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.ProcedureBillings
{
    public class ProcedureBillingRepository : RepositoryBase<ProcedureBilling>, IProcedureBillingRepository
    {
        public ProcedureBillingRepository(IProcedureContextDb unitOfWork) : base(unitOfWork) { }
    }
}
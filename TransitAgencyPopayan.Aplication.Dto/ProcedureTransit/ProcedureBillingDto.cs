using TransitAgencyPopayan.Aplication.Dto.Base;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit.Billings;

namespace TransitAgencyPopayan.Aplication.Dto.ProcedureTransit
{
    public class ProcedureBillingDto : DataTransferObjectBase
    {
        public int ProcedureBillingId { get; set; }

        public int BillingId { get; set; }

        public BillingDto? Billing { get; set; }

        public int ProcedureId { get; set; }

        public ProcedureDto? Procedure { get; set; }
    }
}
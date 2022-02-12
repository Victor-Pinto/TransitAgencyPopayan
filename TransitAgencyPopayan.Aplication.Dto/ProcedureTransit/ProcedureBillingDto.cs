using TransitAgencyPopayan.Aplication.Dto.Base;

namespace TransitAgencyPopayan.Aplication.Dto.ProcedureTransit
{
    public class ProcedureBillingDto : DataTransferObjectBase
    {
        public int BillingId { get; set; }

        public BillingDto Billing { get; set; }

        public int ProcedureId { get; set; }

        public ProcedureDto Procedure { get; set; }
    }
}
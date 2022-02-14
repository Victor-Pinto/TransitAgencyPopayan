using TransitAgencyPopayan.Aplication.Dto.Base;

namespace TransitAgencyPopayan.Aplication.Dto.ProcedureTransit.Billings
{
    public class BillingSearchPropsDto : DataTransferObjectBase
    {
        public DateTimeOffset? InitialDate { get; set; }

        public DateTimeOffset? FinalDate { get; set; }

        public string? LicensePlate { get; set; }

        public string? OwnerIdentification { get; set; }
    }
}

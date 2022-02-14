using System.ComponentModel.DataAnnotations;
using TransitAgencyPopayan.Aplication.Dto.Base;

namespace TransitAgencyPopayan.Aplication.Dto.ProcedureTransit.Billings
{
    public class BillingDto : DataTransferObjectBase
    {

        public int BillingId { get; set; }

        [Required]
        public int Number { get; set; }

        public DateTimeOffset Date { get; set; }

        [Required]
        public int VehicleId { get; set; }

        public VehicleDto? Vehicle { get; set; }

        public string? Observation { get; set; }

    }
}

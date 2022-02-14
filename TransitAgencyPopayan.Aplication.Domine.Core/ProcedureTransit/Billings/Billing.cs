using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransitAgencyPopayan.Aplication.Domine.Core.Base;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Vehicles;

namespace TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Billings
{
    public class Billing : EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BillingId { get; set; }

        [Required]
        public int Number { get; set; }

        public DateTimeOffset Date { get; set; }

        [Required]
        public int VehicleId { get; set; }

        public virtual Vehicle? Vehicle { get; set; }

        public string? Observation { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransitAgencyPopayan.Aplication.Domine.Core.Base;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Lines;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.TypeServices;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleClasses;

namespace TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Vehicles
{
    public class Vehicle : EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int VehicleId { get; set; }

        [Required]
        public string LicensePlate { get; set; }

        public int LineId { get; set; }

        public virtual Line Line { get; set; }

        public string Model { get; set; }

        public int MotorNumber { get; set; }

        public string Color { get; set; }

        public int VehiculeClassId { get; set; }

        public virtual VehicleClass VehiculeClass { get; set; }

        public int TypeServiceId { get; set; }

        public virtual TypeService TypeService { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleClasses
{
    public class VehicleClass : ProcedureTransitBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int VehiculeClassId { get; set; }
    }
}
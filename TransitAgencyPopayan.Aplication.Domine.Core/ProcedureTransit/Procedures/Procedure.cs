using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Procedures
{
    public class Procedure : ProcedureTransitBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ProcedureId { get; set; }

        public float Value { get; set; }
    }
}
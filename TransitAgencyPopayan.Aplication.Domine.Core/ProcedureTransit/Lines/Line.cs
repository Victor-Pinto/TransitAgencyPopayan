using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Lines
{
    public class Line : ProcedureTransitBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int LineId { get; set; }

        public int BrandId { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Brands
{
    public class Brand : ProcedureTransitBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BrandId { get; set; }
    }
}
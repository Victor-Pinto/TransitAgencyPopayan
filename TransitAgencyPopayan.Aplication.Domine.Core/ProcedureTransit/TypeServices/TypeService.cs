using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.TypeServices
{
    public class TypeService : ProcedureTransitBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TypeServiceId { get; set; }
    }
}
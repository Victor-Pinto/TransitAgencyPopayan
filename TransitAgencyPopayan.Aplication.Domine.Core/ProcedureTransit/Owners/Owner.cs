using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransitAgencyPopayan.Aplication.Domine.Core.Base;

namespace TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Owners
{
    public class Owner : EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int OwnerId { get; set; }

        public string Identification { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Adress { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
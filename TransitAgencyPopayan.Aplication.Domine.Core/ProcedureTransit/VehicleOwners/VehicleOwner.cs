using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransitAgencyPopayan.Aplication.Domine.Core.Base;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Owners;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Vehicles;

namespace TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleOwners
{
    public class VehicleOwner : EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public int VehicleOwnerId { get; set; }



        public int OwnerId { get; set; }


        public virtual Owner? Owner { get; set; }

        public int VehicleId { get; set; }

        public virtual Vehicle? Vehicle { get; set; }
    }
}
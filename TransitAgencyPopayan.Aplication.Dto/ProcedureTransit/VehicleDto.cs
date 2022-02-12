using System.ComponentModel.DataAnnotations;

namespace TransitAgencyPopayan.Aplication.Dto.ProcedureTransit
{
    public class VehicleDto
    {
        public int VehicleId { get; set; }

        [Required]
        public string LicensePlate { get; set; }

        public int LineId { get; set; }

        public LineDto Line { get; set; }

        public string Model { get; set; }

        public int MotorNumber { get; set; }

        public string Color { get; set; }

        public int VehiculeClassId { get; set; }

        public VehicleClassDto VehiculeClass { get; set; }

        public int TypeServiceId { get; set; }

        public TypeServiceDto TypeService { get; set; }
    }
}

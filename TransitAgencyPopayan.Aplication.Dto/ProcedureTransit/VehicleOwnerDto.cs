using TransitAgencyPopayan.Aplication.Dto.Base;

namespace TransitAgencyPopayan.Aplication.Dto.ProcedureTransit
{
    public class VehicleOwnerDto : DataTransferObjectBase
    {
        public int VehicleOwnerId { get; set; }

        public int OwnerId { get; set; }

        public OwnerDto? Owner { get; set; }

        public int VehicleId { get; set; }

        public VehicleDto? Vehicle { get; set; }
    }
}
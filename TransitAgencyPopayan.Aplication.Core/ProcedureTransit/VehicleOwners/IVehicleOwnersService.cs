using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.VehicleOwners
{
    public interface IVehicleOwnerService
    {
        Task<IEnumerable<VehicleOwnerDto>> GetAll();

        Task<VehicleOwnerDto> GetById(int id);

        Task<VehicleOwnerDto> Create(VehicleOwnerDto request);

        Task<bool> Update(VehicleOwnerDto request);

        Task<bool> Delete(int id);
    }
}
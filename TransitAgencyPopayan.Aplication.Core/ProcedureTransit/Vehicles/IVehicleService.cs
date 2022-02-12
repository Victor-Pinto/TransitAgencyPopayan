using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Vehicles
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleDto>> GetAll();

        Task<VehicleDto> GetById(int id);

        Task<VehicleDto> Create(VehicleDto request);

        Task<bool> Update(VehicleDto request);

        Task<bool> Delete(int id);
    }
}
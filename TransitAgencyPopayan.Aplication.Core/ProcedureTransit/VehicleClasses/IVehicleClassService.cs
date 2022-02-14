using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.VehicleClasses
{
    public interface IVehicleClassService
    {
        Task<IEnumerable<VehicleClassDto>> GetAll();

        Task<VehicleClassDto> GetById(int id);

        Task<VehicleClassDto> Create(VehicleClassDto request);

        Task<bool> Update(VehicleClassDto request);

        Task<bool> Delete(int id);
    }
}
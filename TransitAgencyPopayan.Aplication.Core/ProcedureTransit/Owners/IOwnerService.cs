using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Owners
{
    public interface IOwnerService
    {
        Task<IEnumerable<OwnerDto>> GetAll();

        Task<OwnerDto> GetById(int id);

        Task<OwnerDto> Create(OwnerDto request);

        Task<bool> Update(OwnerDto request);

        Task<bool> Delete(int id);
    }
}
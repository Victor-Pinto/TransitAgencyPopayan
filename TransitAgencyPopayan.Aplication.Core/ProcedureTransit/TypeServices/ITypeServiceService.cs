using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.TypeServices
{
    public interface ITypeServiceService
    {
        Task<IEnumerable<TypeServiceDto>> GetAll();

        Task<TypeServiceDto> GetById(int id);

        Task<TypeServiceDto> Create(TypeServiceDto request);

        Task<bool> Update(TypeServiceDto request);

        Task<bool> Delete(int id);
    }
}
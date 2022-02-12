using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Procedures
{
    public interface IProcedureService
    {
        Task<IEnumerable<ProcedureDto>> GetAll();

        Task<ProcedureDto> GetById(int id);

        Task<ProcedureDto> Create(ProcedureDto request);

        Task<bool> Update(ProcedureDto request);

        Task<bool> Delete(int id);
    }
}
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Lines
{
    public interface ILineService
    {
        Task<IEnumerable<LineDto>> GetAll();

        Task<LineDto> GetById(int id);

        Task<LineDto> Create(LineDto request);

        Task<bool> Update(LineDto request);

        Task<bool> Delete(int id);
    }
}
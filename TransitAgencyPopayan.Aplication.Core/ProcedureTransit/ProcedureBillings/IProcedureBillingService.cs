using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.ProcedureBillings
{
    public interface IProcedureBillingService
    {
        Task<IEnumerable<ProcedureBillingDto>> GetAll();

        Task<ProcedureBillingDto> GetById(int id);

        Task<ProcedureBillingDto> Create(ProcedureBillingDto request);

        Task<bool> Update(ProcedureBillingDto request);

        Task<bool> Delete(int id);
    }
}
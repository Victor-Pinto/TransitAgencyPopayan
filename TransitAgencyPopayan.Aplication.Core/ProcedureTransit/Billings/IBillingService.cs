using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Billings
{
    public interface IBillingService
    {
        Task<IEnumerable<BillingDto>> GetAll();

        Task<BillingDto> GetById(int id);

        Task<BillingDto> Create(BillingDto request);

        Task<bool> Update(BillingDto request);

        Task<bool> Delete(int id);
    }
}
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Brands
{
    public interface IBrandService
    {
        Task<IEnumerable<BrandDto>> GetAll();

        Task<BrandDto> GetById(int id);

        Task<BrandDto> Create(BrandDto request);

        Task<bool> Update(BrandDto request);

        Task<bool> Delete(int id);
    }
}
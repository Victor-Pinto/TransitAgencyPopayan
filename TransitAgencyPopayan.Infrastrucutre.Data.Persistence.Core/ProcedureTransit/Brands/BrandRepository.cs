using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Brands;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Brands
{
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(IContextDb dbContext) : base(dbContext) { }
    }
}
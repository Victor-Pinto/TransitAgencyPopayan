using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Brands;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.ProcedureTransit;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Brands
{
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(IProcedureContextDb unitOfWork) : base(unitOfWork) { }
    }
}
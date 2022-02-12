using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.TypeServices;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.TypeServices
{
    public class TypeServiceRepository : RepositoryBase<TypeService>, ITypeServiceRepository
    {
        public TypeServiceRepository(IContextDb dbContext) : base(dbContext) { }
    }
}
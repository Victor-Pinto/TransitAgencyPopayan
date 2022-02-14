using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.TypeServices;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.ProcedureTransit;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.TypeServices
{
    public class TypeServiceRepository : RepositoryBase<TypeService>, ITypeServiceRepository
    {
        public TypeServiceRepository(IProcedureContextDb unitOfWork) : base(unitOfWork) { }
    }
}
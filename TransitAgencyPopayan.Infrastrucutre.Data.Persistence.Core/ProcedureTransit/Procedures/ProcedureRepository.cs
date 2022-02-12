using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Procedures;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Procedures
{
    public class ProcedureRepository : RepositoryBase<Procedure>, IProcedureRepository
    {
        public ProcedureRepository(IContextDb dbContext) : base(dbContext) { }
    }
}
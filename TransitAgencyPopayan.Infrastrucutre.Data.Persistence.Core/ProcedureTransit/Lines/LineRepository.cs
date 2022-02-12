using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Lines;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Lines
{
    public class LineRepository : RepositoryBase<Line>, ILineRepository
    {
        public LineRepository(IContextDb dbContext) : base(dbContext) { }
    }
}
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Lines;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.ProcedureTransit;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Lines
{
    public class LineRepository : RepositoryBase<Line>, ILineRepository
    {
        public LineRepository(IProcedureContextDb unitOfWork) : base(unitOfWork) { }
    }
}
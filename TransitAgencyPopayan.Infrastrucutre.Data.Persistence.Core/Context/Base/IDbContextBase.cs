using TransitAgencyPopayan.Aplication.Domine.Core.Base;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.Base
{
    public interface IDbContextBase : IUnitOfWork, IDisposable
    {
    }
}
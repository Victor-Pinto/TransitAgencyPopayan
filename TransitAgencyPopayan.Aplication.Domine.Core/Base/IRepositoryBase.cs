using System.Linq.Expressions;

namespace TransitAgencyPopayan.Aplication.Domine.Core.Base
{
    public interface IRepositoryBase<T>
    {
        IUnitOfWork UnitOfWork { get; }
        Task<T> Insert(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(int id);
        Task<IEnumerable<T>> SearchMatching(Expression<Func<T, bool>> predicate);
        Task<T> SearchMatchingOneResult(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
    }
}
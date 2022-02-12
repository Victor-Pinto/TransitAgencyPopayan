using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TransitAgencyPopayan.Aplication.Domine.Core.Base;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;

        public IUnitOfWork UnitOfWork => _unitOfWork;

        public RepositoryBase(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        public async Task<T> Insert(T entity)
        {
            try
            {
                var response = await _unitOfWork.Set<T>().AddAsync(entity);
                _unitOfWork.Commit();
                return response.Entity;
            }
            catch (Exception)
            {
                throw new Exception($"No se pudo realizar el registro de la entidad {entity}");
            }

        }
        public Task<bool> Update(T entity)
        {
            try
            {
                var response = _unitOfWork.Set<T>().Update(entity);
                _unitOfWork.Commit();
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                return Task.FromResult(false);
            }
        }

        public Task<bool> Delete(int id)
        {
            try
            {
                var entityToDelete = _unitOfWork.Set<T>().Find(id);
                _unitOfWork.Set<T>().Remove(entityToDelete);
                _unitOfWork.Commit();
                return Task.FromResult(true);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }

        public async Task<IEnumerable<T>> SearchMatching(Expression<Func<T, bool>> predicate) =>
            await _unitOfWork.Set<T>().Where(predicate).ToListAsync().ConfigureAwait(false);

        public async Task<IEnumerable<T>> GetAll() =>
            await _unitOfWork.Set<T>().ToListAsync().ConfigureAwait(false);

        public async Task<T> GetById(int id) =>
           await _unitOfWork.Set<T>().FindAsync(id).ConfigureAwait(false);

        public async Task<T> SearchMatchingOneResult(Expression<Func<T, bool>> predicate) =>
            await _unitOfWork.Set<T>().Where(predicate).FirstOrDefaultAsync().ConfigureAwait(false);

    }
}

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
                if (entity == null)
                    throw new ArgumentException($"No se puede insertar un objeto vacío en {nameof(T)}");

                var response = await _unitOfWork.Set<T>().AddAsync(entity);
                _unitOfWork.Commit();
                return response.Entity;
            }
            catch (Exception e)
            {
                //todo: Victor Eliminar e.Message cuando entre a producción
                throw new Exception($"No se pudo realizar el registro de la entidad {entity}; " +
                    $"error: {e.InnerException}");
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await _unitOfWork.Set<T>().ToListAsync().ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException($"Se produjo un error en la persistencia de datos al insertar en el objeto {nameof(T)}");
            }
        }

        public async Task<T> GetById(int id)
        {
            try
            {
                if (id == 0)
                    throw new ArgumentException("El id no puede ser 0");

                return await _unitOfWork.Set<T>().FindAsync(id).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException($"El id {id} no existe en la base de datos");
            }
        }

        public async Task<IEnumerable<T>> SearchMatching(Expression<Func<T, bool>> predicate) =>
            await _unitOfWork.Set<T>().Where(predicate).ToListAsync().ConfigureAwait(false);

        public async Task<T> SearchMatchingOneResult(Expression<Func<T, bool>> predicate) =>
            await _unitOfWork.Set<T>().Where(predicate).FirstOrDefaultAsync().ConfigureAwait(false);

        public Task<bool> Update(T entity)
        {
            try
            {
                if (entity is null)
                    throw new ArgumentException("El objeto llegó vacío");

                var response = _unitOfWork.Set<T>().Update(entity);
                _unitOfWork.Commit();

                return Task.FromResult(true);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }

        public Task<bool> Delete(int id)
        {
            try
            {
                if (id == 0)
                    throw new ArgumentException("El id no puede ser 0");

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
    }
}

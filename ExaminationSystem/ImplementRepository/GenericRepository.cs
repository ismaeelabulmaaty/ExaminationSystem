using Core.Models;
using Core.Repository.Conttract;

using Microsoft.EntityFrameworkCore;
using Repository.Data;

using System.Linq.Expressions;

namespace Repository.ImplementRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
    {

        private readonly ExaminationDbContext _dbContext;
        public GenericRepository(ExaminationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().Where(x => !x.Deleted); 
        }

        public T GetByID(int id)
        {
            return _dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }
        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public T Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            return entity;
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            entity.Deleted = true;
            Update(entity);
        }

        public void Delete(int id)
        {
            T entity = _dbContext.Find<T>(id);
            Delete(entity);
        }

        public T GetWithTrackinByID(int id)
        {
            return _dbContext.Set<T>()
                .Where(x => !x.Deleted && x.Id == id)
                .AsTracking()
                .FirstOrDefault();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

    }
}

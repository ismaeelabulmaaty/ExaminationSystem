using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.Conttract
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T GetByID(int id);
        T GetWithTrackinByID(int id);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);

        void SaveChanges();

    }
}

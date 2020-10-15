using System.Collections.Generic;
using System.Linq;
using ArticleCase.Core;

namespace ArticleCase.Repository
{
    public interface IRepository<T> where T :BaseEntity
        {
            T Add(T entity);
            void AddRange(IEnumerable<T> entities);
            void Delete(T entity);
            void Update(T entity);
            IQueryable<T> GetQueryable();
            T GetById(int id);
            void SaveChanges();
        }
}
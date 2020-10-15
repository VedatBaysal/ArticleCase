using System.Collections.Generic;
using System.Linq;
using ArticleCase.Core;
using Microsoft.EntityFrameworkCore;

namespace ArticleCase.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private  DbSet<T> Table => _dbContext.Set<T>();
        public T Add(T entity)
        {
            return Table.Add(entity).Entity;
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Table.AddRange(entities);
        }

        public void Delete(T entity)
        {
            Table.Remove(entity);
        }

        public IQueryable<T> GetQueryable()
        {
            return Table;
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State= EntityState.Modified;
        }
    }
}
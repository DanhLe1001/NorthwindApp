using Microsoft.EntityFrameworkCore;
using Northwind.Data;
using Northwind.Data.Entities;
using NorthwindApp.Data.Interfaces;

namespace NorthwindApp.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Delete(Guid entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            var query = _context.Set<T>().AsNoTracking().AsQueryable();
            return query;
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().AsNoTracking().Single(x => x.Id == id);
        }

        public T Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

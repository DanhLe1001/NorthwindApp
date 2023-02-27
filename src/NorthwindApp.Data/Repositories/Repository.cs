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

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking().AsQueryable();
        }
    }
}

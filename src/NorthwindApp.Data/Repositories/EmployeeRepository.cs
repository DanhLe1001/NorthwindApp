using Microsoft.EntityFrameworkCore;
using Northwind.Data;
using Northwind.Data.Entities;
using NorthwindApp.Data.Interfaces;

namespace NorthwindApp.Data.Repositories
{
    public class EmployeeRepository : Repository<EmployeeEntity>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }
        public IEnumerable<EmployeeEntity> SearchEmployee(string keywords)
        {
            return _context.Set<EmployeeEntity>().AsNoTracking().AsQueryable()
                 .Where(x => x.FirstName.Equals(keywords) || x.LastName.Equals(keywords)).ToArray();

        }
    }
}

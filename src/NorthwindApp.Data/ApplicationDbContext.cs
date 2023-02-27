using Microsoft.EntityFrameworkCore;
using Northwind.Data.Entities;

namespace Northwind.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}

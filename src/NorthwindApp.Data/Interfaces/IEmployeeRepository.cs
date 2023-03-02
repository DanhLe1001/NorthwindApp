using Northwind.Data.Entities;

namespace NorthwindApp.Data.Interfaces
{
    public interface IEmployeeRepository : IRepository<EmployeeEntity>
    {
        IEnumerable<EmployeeEntity> SearchEmployee(string keywords);
    }
}

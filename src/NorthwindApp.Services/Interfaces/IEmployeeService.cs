using NorthwindApp.Services.Dtos;

namespace NorthwindApp.Services.Interfaces
{
    public interface IEmployeeService
    {
        //IEnumerable Is a read-only array, can only read, cannot add or remove elements.
        //Only traverse in one direction, from the beginning to the end of the array
        IEnumerable<EmployeesDto> GetAll();
    }
}

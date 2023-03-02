using NorthwindApp.Services.Dtos;

namespace NorthwindApp.Services.Interfaces
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Get all employees
        /// </summary>
        /// <returns></returns>
        IEnumerable<EmployeeDto> GetAll();

        /// <summary>
        /// Create new employee
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        EmployeeDto Create(EmployeeDto model);
        /// <summary>
        /// Update information employee
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        EmployeeDto Update(EmployeeDto model);
        /// <summary>
        /// Delete an employee
        /// </summary>
        /// <param name="Id"></param>
        void Delete(Guid Id);
        /// <summary>
        /// find an employee equal Id
        /// </summary>
        /// <param name="Id"></param>
        EmployeeDto FindEmployeeById(Guid Id);

        /// <summary>
        /// Description 3
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        EmployeeDto UpdatePersonalInformstion(EmployeeDto model);

        /// <summary>
        /// Description 4
        /// </summary>
        /// <param name="avatarBase64">Image encode to Base64</param>
        void UpdateAvatar(string avatarBase64);

        /// <summary>
        /// SearchEmployee equal any
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        IEnumerable<EmployeeDto> SearchEmployeeName(string str);
    }
}

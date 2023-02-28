using AutoMapper;
using Northwind.Data.Entities;
using NorthwindApp.Data.Interfaces;
using NorthwindApp.Services.Dtos;
using NorthwindApp.Services.Interfaces;

namespace NorthwindApp.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;

        private readonly IRepository<EmployeeEntity> _repository;

        public EmployeeService(IMapper mapper, IRepository<EmployeeEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public IEnumerable<EmployeesDto> GetAll()
        {
            var Employees = _repository.GetAll().ToList();
            return _mapper.Map<List<EmployeesDto>>(Employees);
        }

    }
}

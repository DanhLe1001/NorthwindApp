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
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IMapper mapper, IRepository<EmployeeEntity> repository, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _repository = repository;
            _employeeRepository = employeeRepository;
        }
        public IEnumerable<EmployeeDto> GetAll()
        {
            var result = _repository.GetAll().AsEnumerable<EmployeeEntity>().ToList();
            return _mapper.Map<List<EmployeeDto>>(result);
        }
        public EmployeeDto Create(EmployeeDto model)
        {
            var entity = _mapper.Map<EmployeeEntity>(model);
            _repository.Insert(entity);

            return _mapper.Map<EmployeeDto>(entity);
        }

        IEnumerable<EmployeeDto> IEmployeeService.SearchEmployeeName(string str)
        {
            var entity = _employeeRepository.SearchEmployee(str);
            return _mapper.Map<List<EmployeeDto>>(entity);
        }

        public EmployeeDto FindEmployeeById(Guid Id)
        {
            var entity = _repository.GetById(Id);
            return _mapper.Map<EmployeeDto>(entity);
        }

        public EmployeeDto SearchEmployee(string str)
        {
            var entity = _repository;
            return _mapper.Map<EmployeeDto>(entity);
        }

        public EmployeeDto UpdatePersonalInformstion(EmployeeDto model)
        {
            throw new NotImplementedException();
        }

        public void UpdateAvatar(string avatarBase64)
        {
            throw new NotImplementedException();
        }

        public EmployeeDto Update(EmployeeDto model)
        {
            throw new NotImplementedException();
        }


        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }




    }
}

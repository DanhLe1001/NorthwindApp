using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NorthwindApp.Services.Dtos;
using NorthwindApp.Services.Interfaces;

namespace NorthwindApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<EmployeesDto> Get()
        {
            return _employeeService.GetAll();
        }
    }

}

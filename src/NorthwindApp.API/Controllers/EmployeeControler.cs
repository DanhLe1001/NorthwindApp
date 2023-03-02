using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NorthwindApp.API.Models;
using NorthwindApp.Services.Dtos;
using NorthwindApp.Services.Interfaces;

namespace NorthwindApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        private readonly ILogger<EmployeesController> _logger;
        public EmployeesController(ILogger<EmployeesController> logger, IEmployeeService employeeService, IMapper mapper)
        {
            _logger = logger;
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public EmployeeDto FindEmployees(Guid id)
        {
            return _employeeService.FindEmployeeById(id);
        }
        [HttpGet("Search/{keyword}")]
        public IEnumerable<EmployeeDto> SearchEmployeeName(string keyword)
        {
            return _employeeService.SearchEmployeeName(keyword);
        }

        [HttpGet]
        public IEnumerable<EmployeeDto> Get()
        {
            return _employeeService.GetAll();
        }

        [HttpPost]
        public EmployeeDto Create(CreateEmloyeeRequest request)
        {
            var model = _mapper.Map<EmployeeDto>(request);
            return _employeeService.Create(model);
        }
    }

}

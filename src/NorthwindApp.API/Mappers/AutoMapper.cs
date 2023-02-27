using AutoMapper;
using NorthwindApp.API.Models;
using NorthwindApp.Services.Dtos;

namespace NorthwindApp.API.Mappers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<CreateEmloyeeRequest, EmployeesDto>();
        }
    }
}

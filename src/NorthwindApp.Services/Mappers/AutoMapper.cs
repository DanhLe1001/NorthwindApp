using AutoMapper;
using Northwind.Data.Entities;
using NorthwindApp.Services.Dtos;

namespace NorthwindApp.Services.Mappers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            //mapper from service to data (mapper )
            CreateMap<EmployeesDto, EmployeeEntity>()
                .ReverseMap();

        }
    }
}

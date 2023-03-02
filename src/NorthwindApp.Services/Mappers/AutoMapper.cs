using AutoMapper;
using Northwind.Data.Entities;
using NorthwindApp.Services.Dtos;

namespace NorthwindApp.Services.Mappers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<EmployeeDto, EmployeeEntity>()
                .ReverseMap();

        }
    }
}

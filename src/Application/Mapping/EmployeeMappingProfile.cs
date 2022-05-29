using Application.Features.EmployeeFeature.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee, EmployeeDTO>();
            CreateMap<EmployeeDTO, Employee>();

        }
    }
}

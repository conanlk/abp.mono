using abp.mono.Dtos;
using abp.mono.Entities;
using AutoMapper;

namespace abp.mono;

public class monoApplicationAutoMapperProfile : Profile
{
    public monoApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Employee, EmployeeDto>();
        CreateMap<CreateOrUpdateEmployeeDto, Employee>();
    }
}

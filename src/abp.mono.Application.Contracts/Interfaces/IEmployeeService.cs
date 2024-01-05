using System;
using System.Threading.Tasks;
using abp.mono.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace abp.mono.Interfaces;

public interface IEmployeeService : ICrudAppService<EmployeeDto, Guid, PagedAndSortedResultRequestDto, CreateOrUpdateEmployeeDto>
{
}
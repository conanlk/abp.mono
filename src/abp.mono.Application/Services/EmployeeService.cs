using System;
using abp.mono.Dtos;
using abp.mono.Entities;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace abp.mono.Services;

[Authorize]
public class EmployeeService : CrudAppService<Employee, EmployeeDto, Guid, PagedAndSortedResultRequestDto, CreateOrUpdateEmployeeDto>
{
    public EmployeeService(IRepository<Employee, Guid> repository) : base(repository)
    {
    }
}
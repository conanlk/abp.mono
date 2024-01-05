using System;
using Volo.Abp.Application.Dtos;

namespace abp.mono.Dtos;

public class EmployeeDto : AuditedEntityDto<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
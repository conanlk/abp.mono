using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace abp.mono.Entities;

public class Employee : AggregateRoot<Guid>, IMultiTenant
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Guid? TenantId { get; }
}
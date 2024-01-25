using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace abp.mono.Entities;

public class Notification : AggregateRoot<Guid>, IMultiTenant
{ 
    public string Title { get; set; }
    public string Content { get; set; }    
    public Guid? TenantId { get; set; }
}
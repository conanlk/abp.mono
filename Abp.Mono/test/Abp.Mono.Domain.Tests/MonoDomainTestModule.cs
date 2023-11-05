using Abp.Mono.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Mono;

[DependsOn(
    typeof(MonoEntityFrameworkCoreTestModule)
    )]
public class MonoDomainTestModule : AbpModule
{

}

using abp.mono.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace abp.mono;

[DependsOn(
    typeof(monoEntityFrameworkCoreTestModule)
    )]
public class monoDomainTestModule : AbpModule
{

}

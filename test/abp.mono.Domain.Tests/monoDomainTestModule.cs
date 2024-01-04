using Volo.Abp.Modularity;

namespace abp.mono;

[DependsOn(
    typeof(monoDomainModule),
    typeof(monoTestBaseModule)
)]
public class monoDomainTestModule : AbpModule
{

}

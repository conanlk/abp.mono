using Volo.Abp.Modularity;

namespace abp.mono;

[DependsOn(
    typeof(monoApplicationModule),
    typeof(monoDomainTestModule)
    )]
public class monoApplicationTestModule : AbpModule
{

}

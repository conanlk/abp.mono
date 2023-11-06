using Volo.Abp.Modularity;

namespace Abp.Mono;

[DependsOn(
    typeof(MonoApplicationModule),
    typeof(MonoDomainTestModule)
    )]
public class MonoApplicationTestModule : AbpModule
{

}

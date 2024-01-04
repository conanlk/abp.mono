using abp.mono.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace abp.mono.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(monoEntityFrameworkCoreModule),
    typeof(monoApplicationContractsModule)
    )]
public class monoDbMigratorModule : AbpModule
{
}

using Volo.Abp.Modularity;

namespace abp.mono;

public abstract class monoApplicationTestBase<TStartupModule> : monoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

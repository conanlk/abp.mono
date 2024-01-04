using Volo.Abp.Modularity;

namespace abp.mono;

/* Inherit from this class for your domain layer tests. */
public abstract class monoDomainTestBase<TStartupModule> : monoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

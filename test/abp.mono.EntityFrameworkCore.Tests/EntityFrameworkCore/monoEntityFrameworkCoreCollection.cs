using Xunit;

namespace abp.mono.EntityFrameworkCore;

[CollectionDefinition(monoTestConsts.CollectionDefinitionName)]
public class monoEntityFrameworkCoreCollection : ICollectionFixture<monoEntityFrameworkCoreFixture>
{

}

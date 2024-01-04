using abp.mono.Samples;
using Xunit;

namespace abp.mono.EntityFrameworkCore.Applications;

[Collection(monoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<monoEntityFrameworkCoreTestModule>
{

}

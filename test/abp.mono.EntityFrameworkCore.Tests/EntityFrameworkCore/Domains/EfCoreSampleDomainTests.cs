using abp.mono.Samples;
using Xunit;

namespace abp.mono.EntityFrameworkCore.Domains;

[Collection(monoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<monoEntityFrameworkCoreTestModule>
{

}

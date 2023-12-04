using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace abp.mono.Pages;

public class Index_Tests : monoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

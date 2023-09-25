using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace raaghuDocumentation.Pages;

public class Index_Tests : raaghuDocumentationWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

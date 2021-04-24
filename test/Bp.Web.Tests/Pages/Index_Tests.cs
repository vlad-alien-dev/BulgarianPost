using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Bp.Pages
{
    public class Index_Tests : BpWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}

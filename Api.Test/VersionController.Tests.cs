using Api.Controllers;
using Xunit;

namespace Api.Test
{
    public class VersionControllerTests
    {
        public class When_GetVersion_Is_Called
        {
            [Fact]
            public void Then_The_Correct_Version_Is_Returned()
            {
                var controller = new VersionController();

                Assert.Equal("1.0.0.0", controller.GetVersion());
            }
        }
    }
}
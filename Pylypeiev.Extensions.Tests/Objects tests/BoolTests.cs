using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class BoolTests
    {
        [Fact]
        public void YesNoTestWhenTrue()
        {
            //Assert
            Assert.Equal("y", true.ToYesNo("y", "n"));
        }

        [Fact]
        public void YesNoTestWhenFalse()
        {
            //Assert
            Assert.Equal("n", false.ToYesNo("y", "n"));
        }
    }
}

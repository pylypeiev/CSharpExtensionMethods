using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class CharExtensionsTests
    {
        [Fact]
        public void EqualsIgnoreCaseWhenEquals()
        {
            //Assert
            Assert.True('a'.EqualsIgnoreCase('A'));
        }

        [Fact]
        public void EqualsIgnoreCaseWhenNotEquals()
        {
            //Assert
            Assert.False('a'.EqualsIgnoreCase('B'));
        }
    }
}

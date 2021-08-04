using System;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class ByteArrayExtensionsTests
    {
        [Fact]
        public void ToBase64StringTestWhenNull()
        {
            //Arrange
            byte[] arr = null;
            //Act
            var str = arr.ToBase64String();
            //Assert
            Assert.Equal(string.Empty, str);
        }

        [Fact]
        public void ToBase64StringTestWhenEmpty()
        {
            //Arrange
            byte[] arr = Array.Empty<byte>();
            //Act
            var str = arr.ToBase64String();
            //Assert
            Assert.Equal(string.Empty, str);
        }

        [Fact]
        public void ToBase64StringTest()
        {
            //Arrange
            byte[] arr = new byte[] { 1, 0, 1 };
            //Act
            var str = arr.ToBase64String();
            //Assert
            Assert.StartsWith("A", str);
        }
    }
}

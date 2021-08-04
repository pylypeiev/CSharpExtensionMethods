using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class StringEncodingExtensionsTests
    {
        [Fact]
        public void DecodeBase64TestCorrect()
        {
            //Arrange
            string base64 = "dGVzdA==";
            //Act
            var result = base64.DecodeBase64();
            //Assert
            Assert.Equal("test", result);
        }

        [Fact]
        public void DecodeBase64TestWhenNull()
        {
            //Arrange
            string base64 = null;
            //Act
            var result = base64.DecodeBase64();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void EncodeBase64TestCorrect()
        {
            //Arrange
            string str = "test";
            //Act
            var result = str.EncodeBase64();
            //Assert
            Assert.Equal("dGVzdA==", result);
        }

        [Fact]
        public void EncodeBase64TestWhenNull()
        {
            //Arrange
            string base64 = null;
            //Act
            var result = base64.EncodeBase64();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ToMD5TestCorrect()
        {
            //Arrange
            string str = "test";
            //Act
            var result = str.ToMd5();
            //Assert
            Assert.Equal("098f6bcd4621d373cade4e832627b4f6", result);
        }

        [Fact]
        public void ToMD5TestWhenNull()
        {
            //Arrange
            string base64 = null;
            //Act
            var result = base64.ToMd5();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }
    }
}

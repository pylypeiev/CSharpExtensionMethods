using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class IntExtensionsTests
    {
        [Fact]
        public void PercentageTest()
        {
            //Arrange
            int num = 100;
            //Act
            double percentage = num.GetPercentage(10);
            //Assert
            Assert.Equal(10, percentage);
        }

        [Fact]
        public void PercentageTestOnNegative()
        {
            //Arrange
            int num = -100;
            //Act
            double percentage = num.GetPercentage(10);
            //Assert
            Assert.Equal(-10, percentage);
        }

        [Fact]
        public void IsBetweenTest()
        {
            //Arrange
            int num = 10;
            //Act
            bool isBetween = num.IsBetween(0, 100);
            //Assert
            Assert.True(isBetween);
        }

        [Fact]
        public void IsBetweenTestWhenNotBetween()
        {
            //Arrange
            int num = -10;
            //Act
            bool isBetween = num.IsBetween(0, 100);
            //Assert
            Assert.False(isBetween);
        }

        [Fact]
        public void MinTest()
        {
            //Arrange
            int num = 1;
            //Assert
            Assert.Equal(1, num.Min(10));
        }

        [Fact]
        public void MaxTest()
        {
            //Arrange
            int num = 1;
            //Assert
            Assert.Equal(10, num.Max(10));
        }

        [Fact]
        public void ToFileSizeKbTest()
        {
            //Arrange
            int num = 1025;
            //Act
            var fileSize = num.ToFileSize();
            //Assert
            Assert.Equal("1KB", fileSize);
        }

        [Fact]
        public void ToFileSizeGbTest()
        {
            //Arrange
            int num = 1025 * 1024 * 1024;
            //Act
            var fileSize = num.ToFileSize();
            //Assert
            Assert.Equal("1GB", fileSize);
        }

        [Fact]
        public void PlusTest()
        {
            //Assert
            Assert.Equal(2, 1.Plus(1));
        }

        [Fact]
        public void MinusTest()
        {
            //Assert
            Assert.Equal(1, 2.Minus(1));
        }

        [Fact]
        public void DivideTest()
        {
            //Assert
            Assert.Equal(2, 10.DivideBy(5));
        }

        [Fact]
        public void MultiplyTest()
        {
            //Assert
            Assert.Equal(10, 2.MultiplyBy(5));
        }
    }
}

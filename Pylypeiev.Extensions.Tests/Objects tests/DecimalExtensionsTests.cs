using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class DecimalExtensionsTests
    {
        [Fact]
        public void AbsTest()
        {
            //Arrange
            decimal num = -1;
            //Act
            decimal numConverted = num.Abs();
            //Assert
            Assert.Equal(1, numConverted);
        }

        [Fact]
        public void CeilingTest()
        {
            //Arrange
            decimal num = 1.1M;
            //Act
            decimal numConverted = num.Ceiling();
            //Assert
            Assert.Equal(2, numConverted);
        }

        [Fact]
        public void FloorTest()
        {
            //Arrange
            decimal num = 1.1M;
            //Act
            decimal numConverted = num.Floor();
            //Assert
            Assert.Equal(1, numConverted);
        }

        [Fact]
        public void PercentageTest()
        {
            //Arrange
            decimal num = 100M;
            //Act
            decimal percentage = num.GetPercentage(10);
            //Assert
            Assert.Equal(10, percentage);
        }

        [Fact]
        public void PercentageTestOnNegative()
        {
            //Arrange
            decimal num = -100M;
            //Act
            decimal percentage = num.GetPercentage(10);
            //Assert
            Assert.Equal(-10, percentage);
        }

        [Fact]
        public void IsBetweenTest()
        {
            //Arrange
            decimal num = 10;
            //Act
            bool isBetween = num.IsBetween(0, 100);
            //Assert
            Assert.True(isBetween);
        }

        [Fact]
        public void IsBetweenTestWhenNotBetween()
        {
            //Arrange
            decimal num = -10;
            //Act
            bool isBetween = num.IsBetween(0, 100);
            //Assert
            Assert.False(isBetween);
        }

        [Fact]
        public void MinTest()
        {
            //Arrange
            decimal num = 1M;
            //Assert
            Assert.Equal(1, num.Min(10));
        }

        [Fact]
        public void MaxTest()
        {
            //Arrange
            decimal num = 1M;
            //Assert
            Assert.Equal(10, num.Max(10));
        }

        [Fact]
        public void RoundTest()
        {
            //Arrange
            decimal num = 1.100M;
            //Act
            decimal rounded = num.Round();
            //Assert
            Assert.Equal(1, rounded);
        }

        [Fact]
        public void RoundWithFractionalDigitsTest()
        {
            //Arrange
            decimal num = 1.100M;
            //Act
            decimal rounded = num.Round(2);
            //Assert
            Assert.Equal(1.1M, rounded);
        }

        [Fact]
        public void PlusTest()
        {
            //Assert
            Assert.Equal(2M, 1M.Plus(1));
        }

        [Fact]
        public void MinusTest()
        {
            //Assert
            Assert.Equal(1M, 2M.Minus(1));
        }

        [Fact]
        public void DivideTest()
        {
            //Assert
            Assert.Equal(2M, 10M.DivideBy(5));
        }

        [Fact]
        public void MultiplyTest()
        {
            //Assert
            Assert.Equal(10M, 2M.MultiplyBy(5));
        }
    }
}

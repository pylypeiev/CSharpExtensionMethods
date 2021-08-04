using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class DoubleExtensionsTests
    {
        [Fact]
        public void AbsTest()
        {
            //Arrange
            double num = -1;
            //Act
            double numConverted = num.Abs();
            //Assert
            Assert.Equal(1, numConverted);
        }

        [Fact]
        public void CeilingTest()
        {
            //Arrange
            double num = 1.1D;
            //Act
            double numConverted = num.Ceiling();
            //Assert
            Assert.Equal(2, numConverted);
        }

        [Fact]
        public void FloorTest()
        {
            //Arrange
            double num = 1.1D;
            //Act
            double numConverted = num.Floor();
            //Assert
            Assert.Equal(1, numConverted);
        }

        [Fact]
        public void PercentageTest()
        {
            //Arrange
            double num = 100D;
            //Act
            double percentage = num.GetPercentage(10);
            //Assert
            Assert.Equal(10, percentage);
        }

        [Fact]
        public void PercentageTestOnNegative()
        {
            //Arrange
            double num = -100D;
            //Act
            double percentage = num.GetPercentage(10);
            //Assert
            Assert.Equal(-10, percentage);
        }

        [Fact]
        public void IsBetweenTest()
        {
            //Arrange
            double num = 10;
            //Act
            bool isBetween = num.IsBetween(0, 100);
            //Assert
            Assert.True(isBetween);
        }

        [Fact]
        public void IsBetweenTestWhenNotBetween()
        {
            //Arrange
            double num = -10;
            //Act
            bool isBetween = num.IsBetween(0, 100);
            //Assert
            Assert.False(isBetween);
        }

        [Fact]
        public void MinTest()
        {
            //Arrange
            double num = 1D;
            //Assert
            Assert.Equal(1, num.Min(10));
        }

        [Fact]
        public void MaxTest()
        {
            //Arrange
            double num = 1D;
            //Assert
            Assert.Equal(10, num.Max(10));
        }

        [Fact]
        public void RoundTest()
        {
            //Arrange
            double num = 1.100D;
            //Act
            double rounded = num.Round();
            //Assert
            Assert.Equal(1, rounded);
        }

        [Fact]
        public void RoundWithFractionalDigitsTest()
        {
            //Arrange
            double num = 1.100D;
            //Act
            double rounded = num.Round(2);
            //Assert
            Assert.Equal(1.1D, rounded);
        }

        [Fact]
        public void PlusTest()
        {
            //Assert
            Assert.Equal(2D, 1D.Plus(1));
        }

        [Fact]
        public void MinusTest()
        {
            //Assert
            Assert.Equal(1D, 2D.Minus(1));
        }

        [Fact]
        public void DivideTest()
        {
            //Assert
            Assert.Equal(2D, 10D.DivideBy(5));
        }

        [Fact]
        public void MultiplyTest()
        {
            //Assert
            Assert.Equal(10D, 2D.MultiplyBy(5));
        }
    }
}

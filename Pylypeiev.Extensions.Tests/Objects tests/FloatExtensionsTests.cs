using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class FloatExtensionsTests
    {
        [Fact]
        public void AbsTest()
        {
            //Arrange
            float num = -1;
            //Act
            float numConverted = num.Abs();
            //Assert
            Assert.Equal(1, numConverted);
        }


        [Fact]
        public void PercentageTest()
        {
            //Arrange
            float num = 100F;
            //Act
            float percentage = num.GetPercentage(10);
            //Assert
            Assert.Equal(10, percentage);
        }

        [Fact]
        public void PercentageTestOnNegative()
        {
            //Arrange
            float num = -100F;
            //Act
            float percentage = num.GetPercentage(10);
            //Assert
            Assert.Equal(-10, percentage);
        }

        [Fact]
        public void IsBetweenTest()
        {
            //Arrange
            float num = 10;
            //Act
            bool isBetween = num.IsBetween(0, 100);
            //Assert
            Assert.True(isBetween);
        }

        [Fact]
        public void IsBetweenTestWhenNotBetween()
        {
            //Arrange
            float num = -10;
            //Act
            bool isBetween = num.IsBetween(0, 100);
            //Assert
            Assert.False(isBetween);
        }

        [Fact]
        public void MinTest()
        {
            //Arrange
            float num = 1F;
            //Assert
            Assert.Equal(1, num.Min(10));
        }

        [Fact]
        public void MaxTest()
        {
            //Arrange
            float num = 1F;
            //Assert
            Assert.Equal(10, num.Max(10));
        }

        [Fact]
        public void PlusTest()
        {
            //Assert
            Assert.Equal(2F, 1F.Plus(1));
        }

        [Fact]
        public void MinusTest()
        {
            //Assert
            Assert.Equal(1F, 2F.Minus(1));
        }

        [Fact]
        public void DivideTest()
        {
            //Assert
            Assert.Equal(2F, 10F.DivideBy(5));
        }

        [Fact]
        public void MultiplyTest()
        {
            //Assert
            Assert.Equal(10F, 2F.MultiplyBy(5));
        }
    }
}

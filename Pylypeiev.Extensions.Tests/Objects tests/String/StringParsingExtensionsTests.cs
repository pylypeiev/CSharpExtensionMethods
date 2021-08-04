using System;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class StringParsingExtensionsTests
    {
        [Fact]
        public void ToDateTimeCorrectTest()
        {
            //Arrange
            string date = "2021.02.10";
            //Act
            var result = date.ToDateTime();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(10, result.Value.Day);
        }

        [Fact]
        public void ToDateTimeIncorrectTest()
        {
            //Arrange
            string date = "20210.22.40";
            //Act
            var result = date.ToDateTime();
            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToDateWhenNullTest()
        {
            //Arrange
            string date = null;
            //Act
            var result = date.ToDateTime();
            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToDateTimeCorrectWithDefaultTest()
        {
            //Arrange
            string date = "2011.02.10";
            var defaultValue = DateTime.Now;

            //Act
            var result = date.ToDateTime(defaultValue);
            //Assert
            Assert.NotEqual(default, result);
            Assert.Equal(2011, result.Year);
        }

        [Fact]
        public void ToDateTimeIncorrectWithDefaultTest()
        {
            //Arrange
            string date = "20210.22.40";
            var defaultValue = DateTime.Now;
            //Act
            var result = date.ToDateTime(defaultValue);
            //Assert
            Assert.Equal(defaultValue, result);
        }

        [Fact]
        public void ToDateWhenNullWithDefaultTest()
        {
            //Arrange
            string date = null;
            var defaultValue = DateTime.Now;
            //Act
            var result = date.ToDateTime(defaultValue);
            //Assert
            Assert.Equal(defaultValue, result);
        }

        [Fact]
        public void ToDecimalCorrectTest()
        {
            //Arrange
            string num = "1.11";
            //Act
            var result = num.ToDecimal();
            //Assert
            Assert.Equal(1.11M, result);
        }

        [Fact]
        public void ToDecimalInCorrectTest()
        {
            //Arrange
            string num = "1.11M";
            //Act
            var result = num.ToDecimal(1.11M);
            //Assert
            Assert.Equal(1.11M, result);
        }

        [Fact]
        public void ToDoubleCorrectTest()
        {
            //Arrange
            string num = "1.11";
            //Act
            var result = num.ToDouble();
            //Assert
            Assert.Equal(1.11D, result);
        }

        [Fact]
        public void ToDoubleInCorrectTest()
        {
            //Arrange
            string num = "1.11D";
            //Act
            var result = num.ToDouble(1.11D);
            //Assert
            Assert.Equal(1.11D, result);
        }

        [Fact]
        public void ToFloatCorrectTest()
        {
            //Arrange
            string num = "1.11";
            //Act
            var result = num.ToFloat();
            //Assert
            Assert.Equal(1.11F, result);
        }

        [Fact]
        public void ToFloatInCorrectTest()
        {
            //Arrange
            string num = "1.11D";
            //Act
            var result = num.ToFloat(1.11F);
            //Assert
            Assert.Equal(1.11F, result);
        }

        [Fact]
        public void ToIntCorrectTest()
        {
            //Arrange
            string num = "1";
            //Act
            var result = num.ToInt();
            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void ToIntInCorrectTest()
        {
            //Arrange
            string num = "1";
            //Act
            var result = num.ToInt(1);
            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void ToLongCorrectTest()
        {
            //Arrange
            string num = "1";
            //Act
            var result = num.ToLong();
            //Assert
            Assert.Equal(1L, result);
        }

        [Fact]
        public void ToLongInCorrectTest()
        {
            //Arrange
            string num = "1";
            //Act
            var result = num.ToLong(1L);
            //Assert
            Assert.Equal(1L, result);
        }

        [Fact]
        public void ToByteArrayCorrectTest()
        {
            //Arrange
            string str = "123";
            //Act
            var result = str.ToByteArray();
            //Assert
            Assert.NotEmpty(result);
            Assert.Equal(3, result.Length);
        }

        [Fact]
        public void ToByteArrayWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.ToByteArray();
            //Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }
    }
}

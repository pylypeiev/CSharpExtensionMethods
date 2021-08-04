using System;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class DateTimeExtensionsTests
    {
        [Fact]
        public void BetweenTest()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var date1 = DateTime.Now.AddDays(-10);
            var date2 = DateTime.Now.AddDays(10);
            //Act
            var isBetween = dateNow.Between(date1, date2);
            //Assert
            Assert.True(isBetween);
        }

        [Fact]
        public void BetweenTestWhenNotBetween()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var date1 = DateTime.Now.AddDays(10);
            var date2 = DateTime.Now.AddDays(20);
            //Act
            var isBetween = dateNow.Between(date1, date2);
            //Assert
            Assert.False(isBetween);
        }

        [Fact]
        public void CalculateAgeTest()
        {
            //Arrange
            var bDate = DateTime.Now.AddYears(-11);
            //Act
            var age = bDate.CalculateAge();
            //Assert
            Assert.Equal(11, age);
        }

        [Fact]
        public void GetTimeTest()
        {
            //Arrange
            var date = new DateTime(2021, 01, 01, 10, 01, 02);
            //Act
            var time = date.GetTime("HHmmss");
            //Assert
            Assert.Equal(100102, time);
        }

        [Fact]
        public void IsFutureTest()
        {
            //Arrange
            var date1 = DateTime.Now.AddDays(10);
            var date2 = DateTime.Now.AddDays(-20);
            //Act
            var isFuture = date1.IsFuture(date2);
            //Assert
            Assert.True(isFuture);
        }

        [Fact]
        public void IsFutureRelativeToNowTest()
        {
            //Arrange
            var date = DateTime.Now.AddDays(10);
            //Act
            var isFuture = date.IsFuture();
            //Assert
            Assert.True(isFuture);
        }

        [Fact]
        public void IsPastTest()
        {
            //Arrange
            var date1 = DateTime.Now.AddDays(-10);
            var date2 = DateTime.Now.AddDays(20);
            //Act
            var isFuture = date1.IsPast(date2);
            //Assert
            Assert.True(isFuture);
        }

        [Fact]
        public void IsPastRelativeToNowTest()
        {
            //Arrange
            var date = DateTime.Now.AddDays(-10);
            //Act
            var isFuture = date.IsPast();
            //Assert
            Assert.True(isFuture);
        }

        [Fact]
        public void IsDefaultTest()
        {
            //Arrange
            var date = new DateTime();
            //Act
            var isDefault = date.IsDefault();
            //Assert
            Assert.True(isDefault);
        }

        [Fact]
        public void IsDefaultTestWhenNotDefault()
        {
            //Arrange
            var date = DateTime.Now;
            //Act
            var isDefault = date.IsDefault();
            //Assert
            Assert.False(isDefault);
        }
    }
}

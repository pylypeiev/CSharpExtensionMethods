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

        [Fact]
        public void ToUnixTimeAtEpoch()
        {
            //Arrange
            var date = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            //Act
            var unix = date.ToUnixTime();
            //Assert
            Assert.Equal(0, unix);
        }

        [Fact]
        public void ToUnixTimeAfterEpoch()
        {
            //Arrange
            var date = new DateTime(1970, 1, 1, 0, 0, 1, DateTimeKind.Utc);
            //Act
            var unix = date.ToUnixTime();
            //Assert
            Assert.Equal(1000, unix);
        }

        [Fact]
        public void ToUnixTimeBeforeEpoch()
        {
            //Arrange
            var date = new DateTime(1969, 12, 31, 23, 59, 59, DateTimeKind.Utc);
            //Act
            var unix = date.ToUnixTime();
            //Assert
            Assert.Equal(-1000, unix);
        }


        [Fact]
        public void TrimToSecondTest()
        {
            //Arrange
            var date = new DateTime(1969, 12, 31, 23, 59, 59, DateTimeKind.Utc);
            //Act
            var trimmed = date.TrimToSecond();
            //Assert
            Assert.Equal(0, trimmed.Millisecond);
            Assert.Equal(date.Second, trimmed.Second);
        }

        [Fact]
        public void TrimToMinuteTest()
        {
            //Arrange
            var date = new DateTime(1969, 12, 31, 23, 59, 59, DateTimeKind.Utc);
            //Act
            var trimmed = date.TrimToMinute();
            //Assert
            Assert.Equal(0, trimmed.Millisecond);
            Assert.Equal(0, trimmed.Second);
            Assert.Equal(date.Minute, trimmed.Minute);
        }

        [Fact]
        public void TrimToHourTest()
        {
            //Arrange
            var date = new DateTime(1969, 12, 31, 23, 59, 59, DateTimeKind.Utc);
            //Act
            var trimmed = date.TrimToHour();
            //Assert
            Assert.Equal(0, trimmed.Millisecond);
            Assert.Equal(0, trimmed.Second);
            Assert.Equal(0, trimmed.Minute);
            Assert.Equal(date.Hour, trimmed.Hour);
        }

        [Fact]
        public void TrimToDateTest()
        {
            //Arrange
            var date = new DateTime(1969, 12, 31, 23, 59, 59, DateTimeKind.Utc);
            //Act
            var trimmed = date.TrimToDay();
            //Assert
            Assert.Equal(0, trimmed.Millisecond);
            Assert.Equal(0, trimmed.Second);
            Assert.Equal(0, trimmed.Minute);
            Assert.Equal(0, trimmed.Hour);
            Assert.Equal(date.Day, trimmed.Day);
        }

        [Fact]
        public void GetQuarterAtEndOfYearTest()
        {
            //Arrange
            var date = new DateTime(1969, 12, 31, 23, 59, 59, DateTimeKind.Utc);
            //Act
            var quarter = date.GetQuarter();
            //Assert
            Assert.Equal(4, quarter);
        }

        [Fact]
        public void GetQuarterAtBeginingOfYearTest()
        {
            //Arrange
            var date = new DateTime(1970, 1, 1, 0, 0, 1, DateTimeKind.Utc);
            //Act
            var quarter = date.GetQuarter();
            //Assert
            Assert.Equal(1, quarter);
        }
    }
}

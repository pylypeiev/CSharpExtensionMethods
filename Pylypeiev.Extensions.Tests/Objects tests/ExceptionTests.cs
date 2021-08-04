using System;
using System.Linq;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class ExceptionTests
    {
        [Fact]
        public void GetInnermostExceptionTest()
        {
            //Arrange
            var ex = new Exception("level 1", new Exception("level 2", new Exception("level 3")));
            //Act
            var innerEx = ex.GetInnerExceptions();
            //Assert
            Assert.Equal(2, innerEx.Count());
        }

        [Fact]
        public void GetInnerExceptionsTest()
        {
            //Arrange
            var ex = new Exception("level 1", new Exception("level 2", new Exception("level 3")));
            //Act
            var innerEx = ex.GetInnermostException();
            //Assert
            Assert.Equal("level 3", innerEx.Message);
        }
    }
}

using System;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{

    public class FuncTests
    {
        [Fact]
        public void OrOnPredicate()
        {
            //Arrange
            Predicate<int> p1 = (x) => 1 == 2;
            Predicate<int> p2 = (x) => 1 == 1;
            //Act
            var result = p1.Or(p2)(1);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void OrOnFuncNoArguments()
        {
            //Arrange
            Func<bool> f1 = () => 1 == 2;
            Func<bool> f2 = () => 1 == 1;
            //Act
            var result = f1.Or(f2)();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void OrOnFuncWith1Argument()
        {
            //Arrange
            Func<int, bool> f1 = (x) => 1 == 2;
            Func<int, bool> f2 = (x) => 1 == 1;
            //Act
            var result = f1.Or(f2)(1);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void OrOnFuncWith2Argument()
        {
            //Arrange
            Func<int, int, bool> f1 = (x, y) => 1 == 2;
            Func<int, int, bool> f2 = (x, y) => 1 == 1;
            //Act
            var result = f1.Or(f2)(1, 2);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void OrOnFuncWith3Argument()
        {
            //Arrange
            Func<int, int, int, bool> f1 = (x, y, z) => 1 == 2;
            Func<int, int, int, bool> f2 = (x, y, z) => 1 == 1;
            //Act
            var result = f1.Or(f2)(1, 2, 3);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void AndOnPredicate()
        {
            //Arrange
            Predicate<int> p1 = (x) => 1 == 1;
            Predicate<int> p2 = (x) => 2 == 2;
            //Act
            var result = p1.And(p2)(1);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void AndOnFuncNoArguments()
        {
            //Arrange
            Func<bool> f1 = () => 1 == 1;
            Func<bool> f2 = () => 2 == 2;
            //Act
            var result = f1.And(f2)();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void AndOnFuncWith1Argument()
        {
            //Arrange
            Func<int, bool> f1 = (x) => 1 == 1;
            Func<int, bool> f2 = (x) => 2 == 2;
            //Act
            var result = f1.And(f2)(1);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void AndOnFuncWith2Argument()
        {
            //Arrange
            Func<int, int, bool> f1 = (x, y) => 1 == 1;
            Func<int, int, bool> f2 = (x, y) => 2 == 2;
            //Act
            var result = f1.And(f2)(1, 2);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void AndOnFuncWith3Argument()
        {
            //Arrange
            Func<int, int, int, bool> f1 = (x, y, z) => 1 == 1;
            Func<int, int, int, bool> f2 = (x, y, z) => 2 == 2;
            //Act
            var result = f1.And(f2)(1, 2, 3);
            //Assert
            Assert.True(result);
        }
    }
}

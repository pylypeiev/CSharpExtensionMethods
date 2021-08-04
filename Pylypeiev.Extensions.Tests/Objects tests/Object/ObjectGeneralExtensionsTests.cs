using System;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class ObjectGeneralExtensionsTests
    {
        [Fact]
        public void IfNotNullTestWhenNotNullOnAction()
        {
            //Arrange
            object obj = new { name = "Some name", age = 18 };
            bool ifExecuted = false;

            //Act
            obj.IfNotNull((Action<object>)((_) => ifExecuted = true));
            //Assert
            Assert.True(ifExecuted);
        }

        [Fact]
        public void IfNotNullTestWhenNullOnAction()
        {
            //Arrange
            object obj = null;
            bool ifExecuted = false;
            //Act
            obj.IfNotNull((Action<object>)((_) => ifExecuted = true));
            //Assert
            Assert.False(ifExecuted);
        }

        [Fact]
        public void IfNotNullTestWhenNotNullOnFunc()
        {
            //Arrange
            object obj = new { name = "Some name", age = 18 };
            bool ifExecuted = false;
            //Act
            obj.IfNotNull(x => ifExecuted = true);
            //Assert
            Assert.True(ifExecuted);
        }

        [Fact]
        public void IfNotNullTestWhenNullOnFunc()
        {
            //Arrange
            object obj = null;
            bool ifExecuted = false;
            //Act
            obj.IfNotNull(x => ifExecuted = true);
            //Assert
            Assert.False(ifExecuted);
        }

        [Fact]
        public void IfNotNullTestWhenNotNullOnFuncWithDefaultValue()
        {
            //Arrange
            object obj = new { name = "Some name", age = 18 };
            //Act
            var result = obj.IfNotNull(x => 10, 1);
            //Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void IfNotNullTestWhenNullOnFuncWithDefaultValue()
        {
            //Arrange
            object obj = null;
            //Act
            var result = obj.IfNotNull(x => 10, 1);
            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void IsDefaultValueTestWhenNotDefault()
        {
            //Arrange
            object obj = new { name = "Some name", age = 18 };
            //Act
            var isDefault = obj.IsDefaultValue();
            //Assert
            Assert.False(isDefault);
        }

        [Fact]
        public void IsDefaultValueTestWhenDefault()
        {
            //Arrange
            int obj = 0;
            //Act
            var isDefault = obj.IsDefaultValue();
            //Assert
            Assert.True(isDefault);
        }

        [Fact]
        public void IsInTestWhenIn()
        {
            //Arrange
            object obj = 1;
            //Act
            var isIn = obj.IsIn(1, 2, 3, 5);
            //Assert
            Assert.True(isIn);
        }

        [Fact]
        public void IsInTestWhenNotInTest()
        {
            //Arrange
            object obj = 1;
            //Act
            var isIn = obj.IsIn(2, 3, 5);
            //Assert
            Assert.False(isIn);
        }

        [Fact]
        public void IsNotNullWhenNotNullTest()
        {
            //Arrange
            object obj = 1;
            //Act
            var isNotNull = obj.IsNotNull();
            //Assert
            Assert.True(isNotNull);
        }

        [Fact]
        public void IsNotNullWhenNullTest()
        {
            //Arrange
            object obj = null;
            //Act
            var isNotNull = obj.IsNotNull();
            //Assert
            Assert.False(isNotNull);
        }

        [Fact]
        public void IsNullWhenNotNullTest()
        {
            //Arrange
            object obj = 1;
            //Act
            var isNull = obj.IsNull();
            //Assert
            Assert.False(isNull);
        }

        [Fact]
        public void IsNullWhenNullTest()
        {
            //Arrange
            object obj = null;
            //Act
            var isNull = obj.IsNull();
            //Assert
            Assert.True(isNull);
        }

        [Fact]
        public void ToStringSafeWhenNullTest()
        {
            //Arrange
            object obj = null;
            //Act
            var str = obj.ToStringSafe();
            //Assert
            Assert.Equal(string.Empty, str);
        }

        [Fact]
        public void ToStringSafeWhenNotNullTest()
        {
            //Arrange
            object obj = 1;
            //Act
            var str = obj.ToStringSafe();
            //Assert
            Assert.Equal("1", str);
        }

        [Fact]
        public void TryTestOnFunctionSucceed()
        {
            //Arrange
            object obj = 1;
            //Act
            var result = obj.Try(x => 100);
            //Assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void TryTestOnFunctionFailed()
        {
            //Arrange
            object obj = 1;
            //Act
            var result = obj.Try(x => { throw new Exception(); return 110; });
            //Assert
            Assert.Equal(default, result);
        }

        [Fact]
        public void TryTestOnFunctionSucceedWithDefaultParameter()
        {
            //Arrange
            object obj = 1;
            //Act
            var result = obj.Try(x => 100, 10);
            //Assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void TryTestOnFunctionFailedWithDefaultParameter()
        {
            //Arrange
            object obj = 1;
            //Act
            var result = obj.Try(x => { throw new Exception(); return 110; }, 2);
            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void TryTestOnFunctionSucceedWithOutParameter()
        {
            //Arrange
            object obj = 1;
            //Act
            var ifExecuted = obj.Try(x => 100, out int outParam);
            //Assert
            Assert.True(ifExecuted);
            Assert.Equal(100, outParam);
        }

        [Fact]
        public void TryTestOnFunctionFailedWithOutarameter()
        {
            //Arrange
            object obj = 1;
            //Act
            var ifExecuted = obj.Try(x => { throw new Exception(); return 110; }, out int outParam);
            //Assert
            Assert.False(ifExecuted);
            Assert.Equal(default, outParam);
        }

        [Fact]
        public void TryTestOnFunctionFailedWithOutarameterAndDefultValue()
        {
            //Arrange
            object obj = 1;
            //Act
            var ifExecuted = obj.Try(x => { throw new Exception(); return 110; }, 100, out int outParam);
            //Assert
            Assert.False(ifExecuted);
            Assert.Equal(100, outParam);
        }

        [Fact]
        public void TryTestOnActionSucceed()
        {
            //Arrange
            object obj = 1;
            //Act
            var ifExecuted = obj.Try(x => { });
            //Assert
            Assert.True(ifExecuted);
        }

        [Fact]
        public void TryTestOnActionFailed()
        {
            //Arrange
            object obj = 1;
            //Act
            var ifExecuted = obj.Try(x => { throw new Exception(); });
            //Assert
            Assert.False(ifExecuted);
        }

        [Fact]
        public void TryTestOnActionSucceedWithCatchAction()
        {
            //Arrange
            object obj = 1;
            //Act
            var ifExecuted = obj.Try(x => { }, x => { });
            //Assert
            Assert.True(ifExecuted);
        }

        [Fact]
        public void TryTestOnActionFailedWithCatchAction()
        {
            //Arrange
            object obj = 1;
            //Act
            var ifExecuted = obj.Try(x => { throw new Exception(); }, x => { });
            //Assert
            Assert.False(ifExecuted);
        }

        [Fact]
        public void YieldTest()
        {
            //Arrange
            object obj = 1;
            //Act
            var enumerable = obj.Yield();
            //Assert
            Assert.NotEmpty(enumerable);
        }

        [Fact]
        public void DeepCopyTest()
        {
            //Arrange
            object obj = "Some name";
            //Act
            var deepCopy = obj.DeepCopy();
            obj = null;
            //Assert
            Assert.NotEqual(deepCopy, obj);
        }
    }
}

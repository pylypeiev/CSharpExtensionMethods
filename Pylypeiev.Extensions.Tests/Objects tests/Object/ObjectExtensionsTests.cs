using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class ObjectExtensionsTests
    {
        [Fact]
        public void GetPropertiesWithValuesTest()
        {
            //Arrange
            var obj = new { name = "Some name", age = 18 };
            //Act
            var propertiesWithValues = obj.GetPropertiesWithValues();
            //Assert
            Assert.Equal(2, propertiesWithValues.Count);
        }

        [Fact]
        public void GetPropertiesWithValuesOnNullTest()
        {
            //Arrange
            object obj = null;
            //Act
            var propertiesWithValues = obj.GetPropertiesWithValues();
            //Assert
            Assert.Empty(propertiesWithValues);
        }

        [Fact]
        public void GetPropertiesWithValuesIn1StringTest()
        {
            //Arrange
            var obj = new { name = "Some name", age = 18 };
            //Act
            var propertiesWithValues = obj.GetPropertiesWithValues("=", ",");
            //Assert
            Assert.Contains("=", propertiesWithValues);
            Assert.Contains(",", propertiesWithValues);
        }

        [Fact]
        public void GetPropertiesWithValuesIn1StringOnNullTest()
        {
            //Arrange
            object obj = null;
            //Act
            var propertiesWithValues = obj.GetPropertiesWithValues("=", ",");
            //Assert
            Assert.Equal(string.Empty, propertiesWithValues);
        }
    }
}

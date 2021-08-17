using System;
using System.Collections.Generic;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class DictionaryExtensionsTests
    {
        [Fact]
        public void AddIfNotContainsKeyTest()
        {
            //Arrange
            var dict = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
            //Act
            var ifAdded = dict.AddIfNotContainsKey("new key", "new value");
            //Assert
            Assert.True(ifAdded);
            Assert.Equal(3, dict.Count);
        }

        [Fact]
        public void AddIfNotContainsKeyTestWhenExist()
        {
            //Arrange
            var dict = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
            //Act
            var ifAdded = dict.AddIfNotContainsKey("key1", "new value");
            //Assert
            Assert.False(ifAdded);
            Assert.Equal(2, dict.Count);
        }

        [Fact]
        public void AddIfNotContainsKeyTestOnNull()
        {
            //Arrange
            Dictionary<string, string> dict = null;
            //Act
            var ifAdded = dict.AddIfNotContainsKey("key1", "new value");
            //Assert
            Assert.False(ifAdded);
        }

        [Fact]
        public void AddIfNotContainsKeyWhenKeyIsNullTest()
        {
            //Arrange
            var dict = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(() => dict.AddIfNotContainsKey(null, "new value"));
        }

        [Fact]
        public void AddOrUpdateTestOnUpdate()
        {
            //Arrange
            var dict = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
            //Act
            dict.AddOrUpdate("key1", "new value");
            //Assert
            Assert.Equal(2, dict.Count);
        }

        [Fact]
        public void AddOrUpdateTestOnAdd()
        {
            //Arrange
            var dict = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
            //Act
            dict.AddOrUpdate("new key", "new value");
            //Assert
            Assert.Equal(3, dict.Count);
        }

        [Fact]
        public void AddOrUpdateTestOnNull()
        {
            //Arrange
            Dictionary<string, string> dict = null;
            //Act
            var elem = dict.AddOrUpdate("key1", "new value");
            //Assert
            Assert.Null(elem);
        }

        [Fact]
        public void AddOrUpdateWhenKeyIsNullTest()
        {
            //Arrange
            var dict = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
            //Act
            var elem = dict.AddOrUpdate(null, "new value");
            //Assert
            Assert.Null(elem);
            Assert.Equal(2, dict.Count);
        }

        [Fact]
        public void ToTupleTest()
        {
            //Arrange
            var dict = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
            //Act
            var tuple = dict.ToTuple();
            //Assert
            Assert.IsType<List<Tuple<string, string>>>(tuple);
        }

        [Fact]
        public void GetValueOrDefaultTestWhenExist()
        {
            //Arrange
            var dict = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
            //Act
            var value = dict.GetValueOrDefault("key1", "default");
            //Assert
            Assert.Equal("value1", value);
        }

        [Fact]
        public void GetValueOrDefaultTestWhenNotExist()
        {
            //Arrange
            var dict = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
            //Act
            var value = dict.GetValueOrDefault("key11", "default");
            //Assert
            Assert.Equal("default", value);
        }

        [Fact]
        public void AsReadOnlyOkTests()
        {
            //Arrange
            var dict = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
            //Act
            var readonlyCollection = dict.AsReadOnly();
            //Assert
            Assert.Equal(dict.Count, readonlyCollection.Count);
        }

        [Fact]
        public void AsReadOnlyOnEmptyCollection()
        {
            //Arrange
            var dict = new Dictionary<string, string> { };
            //Act
            var readonlyCollection = dict.AsReadOnly();
            //Assert
            Assert.Empty(readonlyCollection);
        }

        [Fact]
        public void AsReadOnlyOnNull()
        {
            //Arrange
            Dictionary<string, string> dict = null;
            //Act
            var readonlyCollection = dict.AsReadOnly();
            //Assert
            Assert.Empty(readonlyCollection);
        }
    }
}

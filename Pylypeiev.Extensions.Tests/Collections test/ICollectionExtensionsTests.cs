using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class ICollectionExtensionsTests
    {
        [Fact]
        public void AddIfNotContainsTest()
        {
            //Arrange
            var collection = Enumerable.Range(1, 10).ToList();
            //Act
            var ifAdded = collection.AddIfNotContains(22);
            //Assert
            Assert.True(ifAdded);
            Assert.Contains(22, collection);
        }

        [Fact]
        public void AddIfNotContainsTestWhenContains()
        {
            //Arrange
            var collection = Enumerable.Range(1, 10).ToList();
            //Act
            var ifAdded = collection.AddIfNotContains(2);
            //Assert
            Assert.False(ifAdded);
            Assert.Contains(2, collection);
        }

        [Fact]
        public void AddIfNotContainsTestWhenNull()
        {
            //Arrange
            List<int> collection = null;
            //Act
            var ifAdded = collection.AddIfNotContains(2);
            //Assert
            Assert.False(ifAdded);
        }

        [Fact]
        public void AddRangeTest()
        {
            //Arrange
            var collection = (ICollection<int>)Enumerable.Range(1, 10).ToList();
            var initialCapacity = collection.Count;
            //Act
            collection.AddRange(1, 2, 3, 4);
            //Assert
            Assert.True(collection.Count > initialCapacity);
        }

        [Fact]
        public void AddRangeOnNullTest()
        {
            //Arrange
            ICollection<int> collection = null;
            //Act
            collection.AddRange(1, 2, 3, 4);
            //Assert
            Assert.Null(collection);
        }

        [Fact]
        public void AddRangeParameterNullTest()
        {
            //Arrange
            var collection = (ICollection<int>)Enumerable.Range(1, 10).ToList();
            var initialCapacity = collection.Count;
            //Act
            collection.AddRange(null);
            //Assert
            Assert.True(collection.Count == initialCapacity);
        }

        [Fact]
        public void AddRangeOneOfParametersNullTest()
        {
            //Arrange
            var collection = (ICollection<string>)Enumerable.Range(1, 10).Select(x => x.ToString()).ToList();
            var initialCapacity = collection.Count;
            //Act
            collection.AddRange("1", "2", null);
            //Assert
            Assert.True(collection.Count > initialCapacity);
        }

        [Fact]
        public void AddRangeWithEnumertableTest()
        {
            //Arrange
            var collection = (ICollection<int>)Enumerable.Range(1, 10).ToList();
            var initialCapacity = collection.Count;
            //Act
            collection.AddRange(Enumerable.Range(100, 110));
            //Assert
            Assert.True(collection.Count > initialCapacity);
        }

        [Fact]
        public void AddRangeWithEnumertableOnNnllTest()
        {
            //Arrange
            ICollection<int> collection = null;
            //Act
            collection.AddRange(Enumerable.Range(100, 110));
            //Assert
            Assert.Null(collection);
        }

        [Fact]
        public void AddRangeWithEnumertableWithNullParameterTest()
        {
            //Arrange
            var collection = (ICollection<int>)Enumerable.Range(1, 10).ToList();
            var initialCapacity = collection.Count;
            //Act
            collection.AddRange(null);
            //Assert
            Assert.True(collection.Count == initialCapacity);
        }

        [Fact]
        public void IsNullOrEmptyTestWhenNotEmpty()
        {
            //Arrange
            var collection = (ICollection<int>)Enumerable.Range(1, 10).ToList();
            //Assert
            Assert.False(collection.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmptyTestWhenEmpty()
        {
            //Arrange
            var collection = (ICollection<int>)Array.Empty<int>();
            //Assert
            Assert.True(collection.IsNullOrEmpty());
        }

        [Fact]
        public void RemoveRangeTest()
        {
            //Arrange
            var collection = (ICollection<int>)Enumerable.Range(1, 10).ToList();
            var initialCapacity = collection.Count;
            //Act
            collection.RemoveRange(1, 2, 3, 4, 5);
            //Assert
            Assert.True(collection.Count < initialCapacity);
        }

        [Fact]
        public void RemoveRangeOnNullTest()
        {
            //Arrange
            ICollection<int> collection = null;
            //Act
            collection.RemoveRange(1, 2, 3, 4, 5);
            //Assert
            Assert.Null(collection);
        }

        [Fact]
        public void RemoveRangeWithNullParameterTest()
        {
            //Arrange
            var collection = (ICollection<int>)Enumerable.Range(1, 10).ToList();
            var initialCapacity = collection.Count;
            //Act
            collection.RemoveRange(null);
            //Assert
            Assert.True(collection.Count == initialCapacity);
        }

        [Fact]
        public void RemoveRangeWithEnumerableOnNullTest()
        {
            //Arrange
            ICollection<int> collection = null;
            //Act
            collection.RemoveRange(Enumerable.Range(1, 3));
            //Assert
            Assert.Null(collection);
        }

        [Fact]
        public void RemoveRangeWithEnumerableMullParameterTest()
        {
            //Arrange
            var collection = (ICollection<int>)Enumerable.Range(1, 10).ToList();
            var initialCapacity = collection.Count;
            IEnumerable<int> ienumerable = null;
            //Act
            collection.RemoveRange(ienumerable);
            //Assert
            Assert.True(collection.Count == initialCapacity);
        }
    }
}

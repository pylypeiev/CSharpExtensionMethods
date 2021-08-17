using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class IEnumerableExtensionsTests
    {
        [Fact]
        public void AppendTest()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10);
            //Act
            var ienumerableNew = ienumerable.Append(11);
            //Assert
            Assert.True(ienumerableNew.Count() == ienumerable.Count() + 1);
        }

        [Fact]
        public void AppendOnNullTest()
        {
            //Arrange
            IEnumerable<int> ienumerable = null;
            //Act
            var ienumerableNew = ienumerable.Append(11);
            //Assert
            Assert.NotNull(ienumerableNew);
        }

        [Fact]
        public void AreAllSameTestWhenNotSame()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10);
            //Act
            var isSame = ienumerable.AreAllSame();
            //Assert
            Assert.False(isSame);
        }

        [Fact]
        public void AreAllSameTestWhenSame()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10).Select(x => "same element");
            //Act
            var isSame = ienumerable.AreAllSame();
            //Assert
            Assert.True(isSame);
        }

        [Fact]
        public void ConcatenateStringTest()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10).Select(x => x.ToString());
            //Act
            var c = ienumerable.Concatenate();
            //Assert
            Assert.Contains("1", c);
            Assert.Contains("5", c);
        }

        [Fact]
        public void ForEachTest()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 2);
            var isExecuted = false;
            //Act
            ienumerable.ForEach(_ => isExecuted = true);
            //Assert
            Assert.True(isExecuted);

        }


        [Fact]
        public void ForEachOnNullTest()
        {
            //Arrange
            IEnumerable<int> ienumerable = null;
            var isExecuted = false;
            //Act
            ienumerable.ForEach(_ => isExecuted = true);
            //Assert
            Assert.False(isExecuted);

        }

        [Fact]
        public void IsEmptyTest()
        {
            //Arrange
            var ienumerable = Array.Empty<int>();
            //Assert
            Assert.True(ienumerable.IsEmpty());
        }

        [Fact]
        public void IsNotEmptyTest()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10);
            //Assert
            Assert.True(ienumerable.IsNotEmpty());
        }

        [Fact]
        public void IsNullOrEmptyTestWhenNull()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10);
            ienumerable = null;
            //Assert
            Assert.True(ienumerable.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmptyTestWhenEmpty()
        {
            //Arrange
            var ienumerable = Array.Empty<int>();
            //Assert
            Assert.True(ienumerable.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmptyTestWhenNotEmpty()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10);
            //Assert
            Assert.False(ienumerable.IsNullOrEmpty());
        }

        [Fact]
        public void JoinTest()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10);
            //Act
            var str = ienumerable.Join(",");
            //Assert
            Assert.Contains(",", str);
        }

        [Fact]
        public void JoinTestOnNull()
        {
            //Arrange
            IEnumerable<int> ienumerable = null;
            //Act
            var str = ienumerable.Join(",");
            //Assert
            Assert.Equal(string.Empty, str);
        }

        [Fact]
        public void PrependTest()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10);
            //Act
            var newIenumerable = ienumerable.Prepend(0);
            //Assert
            Assert.Contains(0, newIenumerable);
        }

        [Fact]
        public void PrependTestOnNull()
        {
            //Arrange
            IEnumerable<int> ienumerable = null;
            //Act
            var newIenumerable = ienumerable.Prepend(0);
            //Assert
            Assert.NotNull(newIenumerable);
        }

        [Fact]
        public void ShuffleTest()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10);
            //Act
            var newIenumerable = ienumerable.Shuffle();
            //Assert
            Assert.True(newIenumerable.First() != ienumerable.First() && ienumerable.Last() != newIenumerable.Last());

        }

        [Fact]
        public void ShuffleTestOnNull()
        {
            //Arrange
            IEnumerable<int> ienumerable = null;
            //Act
            var newIenumerable = ienumerable.Shuffle();
            //Assert
            Assert.Empty(newIenumerable);
        }

        [Fact]
        public void PickRandomTest()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10);
            //Act
            var random = ienumerable.PickRandom(3);
            //Assert
            Assert.True(random.Count() == 3);
        }

        [Fact]
        public void PickRandomSingleTest()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10);
            //Act
            var random = ienumerable.PickRandom();
            //Assert
            Assert.Contains(random, ienumerable);
        }

        [Fact]
        public void PickRandomOnNullTest()
        {
            //Arrange
            IEnumerable<int> ienumerable = null;
            //Act
            var random = ienumerable.PickRandom();
            //Assert
            Assert.Equal(default, random);
        }

        [Fact]
        public void ThisOrEmptyTestWhenNotEmpty()
        {
            //Arrange
            var ienumerable = Enumerable.Range(1, 10);
            //Act
            var newEnumerable = ienumerable.ThisOrEmpty();
            //Assert
            Assert.Equal(newEnumerable, ienumerable);
        }

        [Fact]
        public void ThisOrEmptyTestWhenEmpty()
        {
            //Arrange
            var ienumerable = Array.Empty<int>();
            //Act
            var newEnumerable = ienumerable.ThisOrEmpty();
            //Assert
            Assert.True(!newEnumerable.Any());
        }

        [Fact]
        public void ThisOrEmptyTestWhenNull()
        {
            //Arrange
            IEnumerable<int> ienumerable = null;
            //Act
            var newEnumerable = ienumerable.ThisOrEmpty();
            //Assert
            Assert.True(!newEnumerable.Any());
        }
    }
}

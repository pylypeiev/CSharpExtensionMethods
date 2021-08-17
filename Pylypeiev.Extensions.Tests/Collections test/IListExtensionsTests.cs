using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class IListExtensionsTests
    {
        [Fact]
        public void ChunkByTest()
        {
            //Arrange
            var list = Enumerable.Range(1, 10).ToList();
            //Act
            var chunks = list.ChunkBy(3);
            //Assert
            Assert.True(chunks.FirstOrDefault().Count == 3);
            Assert.True(chunks.LastOrDefault().Count == 1);
        }

        [Fact]
        public void ChunkByOnNullTest()
        {
            //Arrange
            List<int> list = null;
            //Act
            var chunks = list.ChunkBy(3);
            //Assert
            Assert.Empty(chunks);
        }

        [Fact]
        public void CloneTest()
        {
            //Arrange
            var list = Enumerable.Range(1, 10).Select(x => x.ToString()).ToList();
            //Act
            var cloned = list.Clone();
            cloned[0] = "cloned";
            //Assert
            Assert.NotEqual(cloned[0], list[0]);
        }

        [Fact]
        public void CloneTestOnNull()
        {
            //Arrange
            List<string> list = null;
            //Act
            var cloned = list.Clone();
            //Assert
            Assert.Empty(cloned);
        }

        [Fact]
        public void PushTest()
        {
            //Arrange
            var list = Enumerable.Range(1, 10).ToList();
            var initialCapacity = list.Count;
            //Act
            list.Push(11);
            //Assert
            Assert.NotEqual(list.Count, initialCapacity);
            Assert.Equal(11, list.Last());
        }

        [Fact]
        public void GetPermutationsTest()
        {
            //Arrange
            var list = Enumerable.Range(1, 4).ToList();
            //Act
            var permutations = list.GetPermutations();
            //Assert
            Assert.Equal(1 * 2 * 3 * 4, permutations.Count);
            Assert.NotEqual(permutations[0], permutations[1]);
        }

        [Fact]
        public void AsReadOnlyOk()
        {
            //Arrange
            IList<int> list = Enumerable.Range(1, 4).ToList();
            //Act
            var readOnly = list.AsReadOnly();
            //Assert
            Assert.Equal(list.Count, readOnly.Count);
        }


        [Fact]
        public void AsReadOnlyOnEmpty()
        {
            //Arrange
            IList<int> list = new List<int>(0);
            //Act
            var readOnly = list.AsReadOnly();
            //Assert
            Assert.Equal(0, readOnly.Count);
        }

        [Fact]
        public void AsReadOnlyOnNull()
        {
            //Arrange
            IList<int> list = new List<int>(0);
            //Act
            var readOnly = list.AsReadOnly();
            //Assert
            Assert.Equal(0, readOnly.Count);
        }
    }
}

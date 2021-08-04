using System;
using System.Linq;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class ArrayExtensionsTests
    {
        [Fact]
        public void ClearAllTest()
        {
            //Arrange
            var arr = Enumerable.Range(1, 10).ToArray();
            //Act
            arr.ClearAll<int>();
            //Assert
            Assert.Equal(default, arr[0]);
        }

        [Fact]
        public void ClearAllOnNullTest()
        {
            //Arrange
            int[] arr = null;
            //Act
            arr.ClearAll<int>();
            //Assert
            Assert.Equal(default, arr);
        }

        [Fact]
        public void ClearAllOnEmptyTest()
        {
            //Arrange
            int[] arr = Array.Empty<int>();
            //Act
            arr.ClearAll<int>();
            //Assert
            Assert.Equal(Array.Empty<int>(), arr);
        }

        [Fact]
        public void JoinTest()
        {
            //Arrange
            var arr = Enumerable.Range(1, 10).ToArray();
            //Act
            var str = arr.Join(",");
            //Assert
            Assert.Contains(",", str);
        }

        [Fact]
        public void JoinWhenNullTest()
        {
            //Arrange
            int[] arr = null;
            //Act
            var str = arr.Join(",");
            //Assert
            Assert.Equal(string.Empty, str);
        }

        [Fact]
        public void JoinWhenArgumentNullTest()
        {
            //Arrange
            var arr = Enumerable.Range(1, 10).ToArray();
            //Act
            var str = arr.Join(null);
            //Assert
            Assert.NotNull(str);
        }

        [Fact]
        public void ToArrayStringTest()
        {
            //Arrange
            var arr = Enumerable.Range(1, 10).ToArray();
            //Act
            var str = arr.ToArrayString();
            //Assert
            Assert.Contains("]", str);
        }

        [Fact]
        public void ToArrayStringOnEmptyTest()
        {
            //Arrange
            var arr = Array.Empty<int>();
            //Act
            var str = arr.ToArrayString();
            //Assert
            Assert.Contains("[]", str);
        }

        [Fact]
        public void ToArrayStringOnJaggedArrayTest()
        {
            //Arrange
            var arr = new int[][]
                                {
                                new int[] { 1, 3, 5, 7, 9 },
                                new int[] { 0, 2, 4, 6 },
                                new int[] { 11, 22 }
                                };
            //Act
            var str = arr.ToArrayString();
            //Assert
            Assert.Contains("]]", str);
        }

        [Fact]
        public void ToArrayStringOnEmptyJaggedArrayTest()
        {
            //Arrange
            var arr = new int[][] { };
            //Act
            var str = arr.ToArrayString();
            //Assert
            Assert.Contains("[]", str);
        }

        [Fact]
        public void ToArrayStringOn2dArrayTest()
        {
            //Arrange
            var arr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            //Act
            var str = arr.ToArrayString();
            //Assert
            Assert.Contains("]]", str);
        }

        [Fact]
        public void ToArrayStringOn2dEmptyArrayTest()
        {
            //Arrange
            var arr = new int[,] { };
            //Act
            var str = arr.ToArrayString();
            //Assert
            Assert.Contains("[]", str);
        }
    }
}

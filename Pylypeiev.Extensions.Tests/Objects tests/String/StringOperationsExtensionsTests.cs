using System.Globalization;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class StringOperationsExtensionsTests
    {
        [Fact]
        public void RemoveFirstTest()
        {
            //Arrange
            string text = "12345";
            //Act
            var result = text.RemoveFirst(2);
            //Assert
            Assert.NotNull(result);
            Assert.StartsWith("3", result);
        }

        [Fact]
        public void RemoveFirstTestWhenNull()
        {
            //Arrange
            string text = null;
            //Act
            var result = text.RemoveFirst(2);
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void RemoveFirstCharacterTest()
        {
            //Arrange
            string text = "12345";
            //Act
            var result = text.RemoveFirstCharacter();
            //Assert
            Assert.NotNull(result);
            Assert.StartsWith("2", result);
        }

        [Fact]
        public void RemoveFirstCharacterWhenNull()
        {
            //Arrange
            string text = null;
            //Act
            var result = text.RemoveFirstCharacter();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void RemoveLastTest()
        {
            //Arrange
            string text = "12345";
            //Act
            var result = text.RemoveLast(2);
            //Assert
            Assert.NotNull(result);
            Assert.EndsWith("3", result);
        }

        [Fact]
        public void RemoveLastTestWhenNull()
        {
            //Arrange
            string text = null;
            //Act
            var result = text.RemoveLast(2);
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void RemoveLastCharacterTest()
        {
            //Arrange
            string text = "12345";
            //Act
            var result = text.RemoveLastCharacter();
            //Assert
            Assert.NotNull(result);
            Assert.EndsWith("4", result);
        }

        [Fact]
        public void RemoveLastCharacterWhenNull()
        {
            //Arrange
            string text = null;
            //Act
            var result = text.RemoveLastCharacter();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ReversetTest()
        {
            //Arrange
            string text = "12345";
            //Act
            var result = text.Reverse();
            //Assert
            Assert.NotNull(result);
            Assert.StartsWith("5", result);
        }

        [Fact]
        public void ReversetTestWhenNull()
        {
            //Arrange
            string text = null;
            //Act
            var result = text.Reverse();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void SplitCamelCaseTest()
        {
            //Arrange
            string text = "CamelCase";
            //Act
            var result = text.SplitCamelCase();
            //Assert
            Assert.NotNull(result);
            Assert.StartsWith("Camel Case", result);
        }

        [Fact]
        public void SplitCamelCaseTestWhenNull()
        {
            //Arrange
            string text = null;
            //Act
            var result = text.SplitCamelCase();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void SurroundWithTest()
        {
            //Arrange
            string text = "B";
            //Act
            var result = text.SurroundWith("A");
            //Assert
            Assert.NotNull(result);
            Assert.Equal("ABA", result);
        }

        [Fact]
        public void SurroundWithWhenNullTest()
        {
            //Arrange
            string text = null;
            //Act
            var result = text.SurroundWith("");
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void SurroundWithNullTest()
        {
            //Arrange
            string text = "A";
            //Act
            var result = text.SurroundWith(null);
            //Assert
            Assert.NotNull(result);
            Assert.Equal("A", result);
        }

        [Fact]
        public void SurroundWithNullWhenNullTest()
        {
            //Arrange
            string text = null;
            //Act
            var result = text.SurroundWith(null);
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ToTitleCaseTest()
        {
            //Arrange
            string text = "aa bb";
            //Act
            var result = text.ToTitleCase();
            //Assert
            Assert.NotNull(result);
            Assert.StartsWith("Aa Bb", result);
        }

        [Fact]
        public void ToTitleCaseWhenNullTest()
        {
            //Arrange
            string text = null;
            //Act
            var result = text.ToTitleCase();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void TrimTest()
        {
            //Arrange
            string text = "  a  ";
            //Act
            var result = text.TrimSafe();
            //Assert
            Assert.NotNull(result);
            Assert.Equal("a", result);
        }

        [Fact]
        public void TrimTestWhenNull()
        {
            //Arrange
            string text = null;
            //Act
            var result = text.TrimSafe();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ToLowerSafeTest()
        {
            //Arrange
            string text = "A";
            //Act
            var result = text.ToLowerSafe();
            //Assert
            Assert.NotNull(result);
            Assert.Equal("a", result);
        }

        [Fact]
        public void ToLowerSafeTestWhenNull()
        {
            //Arrange
            string text = null;
            //Act
            var result = text.ToLowerSafe();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ToLowerSafeWithCultureTest()
        {
            //Arrange
            string text = "İİİ";
            //Act
            var result = text.ToLowerSafe(new CultureInfo("tr-TR"));
            //Assert
            Assert.NotNull(result);
            Assert.Equal("iii", result);
        }

        [Fact]
        public void ToLowerSafeWithInvariantTest()
        {
            //Arrange
            string text = "İİİ";
            //Act
            var result = text.ToLowerInvariantSafe();
            //Assert
            Assert.NotNull(result);
            Assert.Equal("İİİ", result);
        }

        [Fact]
        public void ToUpperSafeTest()
        {
            //Arrange
            string text = "a";
            //Act
            var result = text.ToUpperSafe();
            //Assert
            Assert.NotNull(result);
            Assert.Equal("A", result);
        }

        [Fact]
        public void ToUpperSafeTestWhenNull()
        {
            //Arrange
            string text = null;
            //Act
            var result = text.ToUpperSafe();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ToUpperSafeWithCultureTest()
        {
            //Arrange
            string text = "iii";
            //Act
            var result = text.ToUpperSafe(new CultureInfo("tr-TR"));
            //Assert
            Assert.NotNull(result);
            Assert.Equal("İİİ", result);
            Assert.NotEqual("III", result);
        }

        [Fact]
        public void ToUpperSafeWithInvariantTest()
        {
            //Arrange
            string text = "İİİ";
            //Act
            var result = text.ToUpperInvariantSafe();
            //Assert
            Assert.NotNull(result);
            Assert.Equal("İİİ", result);
        }
    }
}

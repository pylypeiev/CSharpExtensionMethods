using System;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class StringSearchingExtensionsTests
    {
        [Fact]
        public void EndsWithIgnoreCaseTest()
        {
            //Arrange
            string str = "abC";
            //Act
            var result = str.EndsWithIgnoreCase("c");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void EndsWithIgnoreCaseTestWhenNull()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.EndsWithIgnoreCase("c");
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void EndsWithIgnoreCaseTestWhenArgumentNull()
        {
            //Arrange
            string str = "abC";
            //Act
            var result = str.EndsWithIgnoreCase(null);
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void EqualsIgnoreCaseTest()
        {
            //Arrange
            string str = "a";
            //Act
            var result = str.EndsWithIgnoreCase("A");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void EqualsIgnoreCaseWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.EndsWithIgnoreCase("a");
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void EqualsIgnoreCaseWhenParameterNullTest()
        {
            //Arrange
            string str = "a";
            //Act
            var result = str.EndsWithIgnoreCase(null);
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IfNullThenTest()
        {
            //Arrange
            string str = "a";
            //Act
            var result = str.IfNullThen("b");
            //Assert
            Assert.Equal("a", result);
        }

        [Fact]
        public void IfNullThenTestWhenNull()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.IfNullThen("b");
            //Assert
            Assert.Equal("b", result);
        }

        [Fact]
        public void IsAlphaCorrectTest()
        {
            //Arrange
            string str = "a";
            //Act
            var result = str.IsAlpha();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAlphaIncorrectTest()
        {
            //Arrange
            string str = "a1";
            //Act
            var result = str.IsAlpha();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsAlphaWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.IsAlpha();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsAlphaNumericCorrectTest()
        {
            //Arrange
            string str = "a1";
            //Act
            var result = str.IsAlphaNumeric();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAlphaNumericIncorrectTest()
        {
            //Arrange
            string str = "a1!";
            //Act
            var result = str.IsAlphaNumeric();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsAlphaNumericWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.IsAlphaNumeric();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNumericCorrectTest()
        {
            //Arrange
            string str = "1";
            //Act
            var result = str.IsNumeric();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNumericIncorrectTest()
        {
            //Arrange
            string str = "a1";
            //Act
            var result = str.IsNumeric();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNumericWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.IsNumeric();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNullOrEmptyWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.IsNullOrEmpty();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrEmptyWhenNotNullTest()
        {
            //Arrange
            string str = "a1";
            //Act
            var result = str.IsNullOrEmpty();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNullOrWhiteSpaceWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.IsNullOrWhiteSpace();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrWhiteSpaceWhenEmptyTest()
        {
            //Arrange
            string str = "   ";
            //Act
            var result = str.IsNullOrWhiteSpace();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrWhiteSpaceWhenNotNullTest()
        {
            //Arrange
            string str = "a1";
            //Act
            var result = str.IsNullOrWhiteSpace();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindromeCorrectTest()
        {
            //Arrange
            string str = "ABBA";
            //Act
            var result = str.IsPalindrome();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindromeIncorrectTest()
        {
            //Arrange
            string str = "ABBAB";
            //Act
            var result = str.IsPalindrome();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindromeWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.IsPalindrome();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidEmailCorrectTest()
        {
            //Arrange
            string str = "a@a.a";
            //Act
            var result = str.IsValidEmail();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidEmailIncorrectTest()
        {
            //Arrange
            string str = "aa@aa";
            //Act
            var result = str.IsValidEmail();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidEmailWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.IsValidEmail();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidIPCorrectTest()
        {
            //Arrange
            string str = "10.0.0.0";
            //Act
            var result = str.IsValidIP();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidIPIncorrectTest()
        {
            //Arrange
            string str = "aa@aa";
            //Act
            var result = str.IsValidIP();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidIPWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.IsValidIP();
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void NthIndexOfFirstCorrectTest()
        {
            //Arrange
            string str = "ababa";
            //Act
            var result = str.NthIndexOf("b", 1);
            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void NthIndexOfSecondCorrectTest()
        {
            //Arrange
            string str = "ababa";
            //Act
            var result = str.NthIndexOf("b", 2);
            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void NthIndexOfOutOfRangeInCorrectTest()
        {
            //Arrange
            string str = "ababa";
            //Act
            var result = str.NthIndexOf("b", 6);
            //Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void NthIndexInCorrectTest()
        {
            //Arrange
            string str = "ababa";
            //Act
            var result = str.NthIndexOf("c", 1);
            //Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void NthIndexInWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.NthIndexOf("c", 1);
            //Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void NthIndexInWhenParameterNullTest()
        {
            //Arrange
            string str = "a";
            //Act
            var result = str.NthIndexOf(null, 1);
            //Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void OccurrenceNumCorrectTest()
        {
            //Arrange
            string str = "ababa";
            //Act
            var result = str.OccurrenceNum("b");
            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void OccurrenceNumIncorrectTest()
        {
            //Arrange
            string str = "ababa";
            //Act
            var result = str.OccurrenceNum("c");
            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void OccurrenceNumWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.OccurrenceNum("c");
            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void OccurrenceNumWhenParameterNullTest()
        {
            //Arrange
            string str = "C";
            //Act
            var result = str.OccurrenceNum(null);
            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void StartsWithIgnoreCaseTest()
        {
            //Arrange
            string str = "Abc";
            //Act
            var result = str.StartsWithIgnoreCase("a");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void StartsWithIgnoreCaseTestWhenNull()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.StartsWithIgnoreCase("c");
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void StartsWithIgnoreCaseTestWhenArgumentNull()
        {
            //Arrange
            string str = "abc";
            //Act
            var result = str.StartsWithIgnoreCase(null);
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsTest()
        {
            //Arrange
            string str = "aba";
            //Act
            var result = str.Contains("B", StringComparison.OrdinalIgnoreCase);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsInvariantSafeWhenNotContainsTest()
        {
            //Arrange
            string str = "aba";
            //Act
            var result = str.ContainsInvariantSafe("C");
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsInvariantSafeWhenNullTest()
        {
            //Arrange
            string str = null;
            //Act
            var result = str.ContainsInvariantSafe("B");
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsInvariantSafeWhenParameterNullTest()
        {
            //Arrange
            string str = "a";
            //Act
            var result = str.ContainsInvariantSafe(null, StringComparison.OrdinalIgnoreCase);
            //Assert
            Assert.False(result);
        }
    }
}

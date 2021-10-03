using System;
using Xunit;

namespace WSI.Common.Tests
{
    public class StringHandlerTests
    {
        [Fact]
        public void SplitByComma_NullString_ThrowsNullReferenceException()
        {
            // Arrange
            string input = null;

            // Assert
            Assert.Throws<NullReferenceException>(() => StringHandler.SplitByComma(input));
        }

        [Fact]
        public void SplitByComma_ValidString_ReturnsValidArray()
        {
            // Arrange
            var input = "one,two,three";
            var expected = new string[] { "one", "two", "three" };

            // Act
            var actual = StringHandler.SplitByComma(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SplitByComma_StringContainsNoCommas_ThrowsArgumentException()
        {
            // Arrange
            var input = "one";
            
            // Assert
            Assert.Throws<ArgumentException>(() => StringHandler.SplitByComma(input));
        }
    }
}

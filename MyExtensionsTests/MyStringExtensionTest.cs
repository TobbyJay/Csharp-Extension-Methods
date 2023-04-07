namespace MyExtensionsTests
{
	public class MyStringExtensionTest
	{
        [Fact]
        public void IsMyStringNullOrEmpty_ReturnsTrueForNullOrEmptyString()
        {
            // Arrange
            string nullString = null;
            string emptyString = string.Empty;

            // Act
            bool resultForNull = nullString.IsMyStringNullOrEmpty();
            bool resultForEmpty = emptyString.IsMyStringNullOrEmpty();

            // Assert
            Assert.True(resultForNull);
            Assert.True(resultForEmpty);
        }

        [Fact]
        public void IsMyStringNullOrEmpty_ReturnsFalseForNonEmptyString()
        {
            // Arrange
            string nonEmptyString = "This is a non-empty string";

            // Act
            bool result = nonEmptyString.IsMyStringNullOrEmpty();

            // Assert
            Assert.False(result);
        }

    }
}

namespace MyExtensionsTests
{
	public class MyDateExtensionTests
	{
        [Fact]
        public void IsDateInRange_ReturnsTrue_ForDateWithinRange()
        {
            // Arrange
            DateTime input = new DateTime(2022, 01, 01);
            DateTime startDate = new DateTime(2021, 01, 01);
            DateTime endDate = new DateTime(2023, 01, 01);

            // Act
            bool result = input.IsDateInRange(startDate, endDate);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsDateInRange_ReturnsFalse_ForDateOutOfRange()
        {
            // Arrange
            DateTime input = new DateTime(2024, 01, 01);
            DateTime startDate = new DateTime(2021, 01, 01);
            DateTime endDate = new DateTime(2023, 01, 01);

            // Act
            bool result = input.IsDateInRange(startDate, endDate);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsDateInRange_ReturnsTrue_ForDateEqualToStartDate()
        {
            // Arrange
            DateTime input = new DateTime(2021, 01, 01);
            DateTime startDate = new DateTime(2021, 01, 01);
            DateTime endDate = new DateTime(2023, 01, 01);

            // Act
            bool result = input.IsDateInRange(startDate, endDate);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsDateInRange_ReturnsTrue_ForDateEqualToEndDate()
        {
            // Arrange
            DateTime input = new DateTime(2023, 01, 01);
            DateTime startDate = new DateTime(2021, 01, 01);
            DateTime endDate = new DateTime(2023, 01, 01);

            // Act
            bool result = input.IsDateInRange(startDate, endDate);

            // Assert
            Assert.True(result);
        }
    }
}

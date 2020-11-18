using Challenges.Arrays;
using Xunit;


namespace Challenges.tests.Arrays
{
     public class FirstDupeTest
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 1, 5 }, 1)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, -1)]
        [InlineData(new[] { 1, 6, 2, 3, 4, 5, 6 }, 6)]
        [InlineData(new[] { 2, 1, 3, 5, 3, 2 }, 3)]
        public void FirstDupeTest_returns_first_dupe(int[] array, int expected)
        {
            // Arrange InlineData

            //Act
            int result = FirstDupelicate.firstDupe(array);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}

using Challenges.Arrays;
using Xunit;

namespace Challenges.tests.Arrays
{
    public class AlmostIncreasingTest
    {
        [Fact]
        public void IncreasingCheck_Returns_false_with_doubles()
        {
            // Arrange
            int[] s = new int[] { 1, 1, 2, 3, 4, 4 };

            // Act 
            bool actual = AlmostIncreasingSequence.IncreasingCheck(s);

            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void IncreasingCheck_Returns_false_with_pattern()
        {
            // Arrange
            int[] s = new int[] { 1, 2, 1, 2 };

            // Act 
            bool actual = AlmostIncreasingSequence.IncreasingCheck(s);

            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void IncreasingCheck_Returns_true_properly()
        {
            // Arrange
            int[] s = new int[] { 10, 1, 2, 3, 4, 5 };

            // Act 
            bool actual = AlmostIncreasingSequence.IncreasingCheck(s);

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void IncreasingCheck_Returns_false_with_repeat_and_less_than()
        {
            // Arrange
            int[] s = new int[] { 1, 2, 3, 4, 5, 3, 5, 6 };

            // Act 
            bool actual = AlmostIncreasingSequence.IncreasingCheck(s);

            // Assert
            Assert.False(actual);
        }
    }
}

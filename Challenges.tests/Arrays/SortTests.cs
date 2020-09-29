using Challenges.Sort;
using Xunit;


namespace Challenges.tests.Arrays
{
    public class SortTests
    {
        public class InsertionTest
        {
            [Theory]
            [InlineData(new[] { 23, 75, 101, 4 }, new int[] { 4, 23, 75, 101 })]
            [InlineData(new[] { 20, 18, 12, 8, 5, -2 }, new int[] { -2, 5, 8, 12, 18, 20 })]
            [InlineData(new[] { 5, 12, 7, 5, 5, 7 }, new int[] { 5, 5, 5, 7, 7, 12 })]
            [InlineData(new[] { 2, 3, 5, 7, 13, 11 }, new int[] { 2, 3, 5, 7, 11, 13 })]
            public void Insertion_array_in_order(int[] newArray, int[] expected)
            {
                // Arrange
                // InlineData

                // Act
                int[] result = InsertionSort.Insertion(newArray);

                //Assert
                Assert.Equal(expected, result);
            }


        }

    }
}
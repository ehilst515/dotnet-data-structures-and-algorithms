using System;
using Challenges.Arrays;
using Xunit;


namespace Challenges.tests.Arrays
{
    public class BinarySearchTests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6}, 2, 1)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7}, 3, 2)]

        ›
        public void BinarySearch_returns_n_location(int[] testArray, int testN, int expected)
        {
            // Arrange
            //InlineData

            //Act
            int result = BinarySearch.Search(testArray, testN);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
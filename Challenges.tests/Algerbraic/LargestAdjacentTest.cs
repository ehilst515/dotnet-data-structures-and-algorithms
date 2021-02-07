using Challenges.Algerbraic;
using Xunit;

namespace Challenges.tests.Algerbraic
{
    public class LargestAdjacentTest
    {
        [Fact]
        public void adjacentElementsProduct_returns_largest_product()
        {
            //Arrange
            int[] inputArray = new[] { 3, 6, -2, -5, 7, 3 };

            //Act
            int actual = LargestAdjacentProduct.AdjacentElementsProduct(inputArray);

            //Assert
            Assert.Equal(21, actual);
        }
    }
}

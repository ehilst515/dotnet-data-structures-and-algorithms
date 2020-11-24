using Challenges.Algerbraic;
using Xunit;


namespace Challenges.tests.Algerbraic
{
    public class StatuesTest
    {
        [Fact]
        public void adjacentElementsProduct_returns_largest_product()
        {
            int[] s = new int[] { 6, 2, 3, 8 };
            int actual = Statues.makeArrayConsecutive2(s);

            Assert.Equal(3, actual);
        }
    }
}

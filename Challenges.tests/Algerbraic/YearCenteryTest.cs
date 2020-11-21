using Challenges.Algerbraic;
using Xunit;

namespace Challenges.tests.Algerbraic
{
    public class YearCenteryTest
    {
        [Theory]
        [InlineData(1951, 20)]
        [InlineData(1700, 17)]
        [InlineData(3, 1)]
        public void CenturyFromYear_Returns_Century(int year, int expected)
        {
            //Arrange
            //InlineData

            //Act 
            int result = YearCentury.CenturyFromYear(year);

            //Assert
            Assert.Equal(expected, result);

        }
    }
}

using Challenges.Strings;
using Xunit;

namespace Challenges.tests.Strings
{
    public class StringTests
    {
        [Theory]
        [InlineData("abacabad", "c")]
        [InlineData("abaababb", "_")]

        public void firstNotRepeatingCharacter_returns_correctly(string s, string exp)
        {
            //Arrange
            //InlineData

            //Act
            var actual = firstNonRepeatChar.firstNotRepeatingCharacter(s);

            //Assert
            Assert.Equal(exp, actual.ToString());
        }

        [Theory]
        [InlineData("aabaa", true)]
        [InlineData("aabac", false)]
        public void CheckPalindrome_returns_correct_bool(string inputString, bool expected)
        {
            //Arrange
            //InlineData

            //Act
            bool actual = Palindrome.checkPalindrome(inputString);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

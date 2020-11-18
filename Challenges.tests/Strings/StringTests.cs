using Challenges.Strings;
using System;
using System.Collections.Generic;
using System.Text;
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
    }
}

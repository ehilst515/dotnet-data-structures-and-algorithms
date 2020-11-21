using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Strings
{
    public class Palindrome
    {
        public static bool checkPalindrome(string inputString)
        {
            int last = inputString.Length - 1;
            for (int i = last; i > 0; i--)
                if (inputString[i] != inputString[last - i])
                    return false;

            return true;


        }
    }
}

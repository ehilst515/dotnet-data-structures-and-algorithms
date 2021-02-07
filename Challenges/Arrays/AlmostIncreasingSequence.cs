using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.tests.Arrays
{
    public class AlmostIncreasingSequence
    {
        public static bool IncreasingCheck(int[] s)
        {
            if (s.Length == 3 && s[0] <= s[2])
                return true;

            if (s.Length == 2 && s[0] <= s[1])
                return true;

            if (s.Length == 3 && s[0] > s[2])
                return false;

            if (s.Length == 2 && s[0] > s[1])
                return false;

            int removeCount = 1;

            for (int i = 2; i < s.Length + 1; i++)
            {
                if (removeCount == 0)
                {
                    if (s[i - 3] == s[i - 1])
                        return false;

                    for (i = i - 2; i < s.Length - 1; i++)
                        if (s[i] >= s[i + 1])
                            return false;

                    return true;
                }

                if (removeCount == 1)
                    if (s[i - 2] >= s[i - 1] || s[i - 2] == s[i])
                        removeCount = 0;

                if (removeCount == 1)
                {

                    if (s[i - 2] >= s[i - 1] && s[i - 2] >= s[i])
                        return false;

                    if ((s[i - 2] > s[i - 1] && s[i - 2] < s[i]) || s[i - 2] == s[i - 1])
                        removeCount = 0;
                }
            }

            return true;
        }

        public static bool IncreaseCheck(int[] s)
        {
            for (int i = 1; i < s.Length; i++)
                if (s[i - 1] >= s[i])
                    for (int j = i + 1; j < s.Length; j++)
                        if (s[j - 1] >= s[j])
                            return false;

            return true;
        }

        public static bool IncreaseCheckHelper(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
                return false;

            return true;
        }
    }
}

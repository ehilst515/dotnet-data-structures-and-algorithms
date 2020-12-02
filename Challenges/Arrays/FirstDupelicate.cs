using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Arrays
{
    public class FirstDupelicate
    {
        public static int firstDupe(int[] a)
        {
            HashSet<int> HS = new HashSet<int>();

            int result = -1;

            for (int i = 0; i < a.Length; i++)
            {
                if (HS.Contains(a[i]))
                {
                    result = a[i];
                    return result;
                }

                else HS.Add(a[i]);
            }

            return result;
        }
    }
}

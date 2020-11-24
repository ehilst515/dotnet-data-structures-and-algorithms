using System;
using System.Collections.Generic;
using System.Text;

//Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue having an non-negative integer size. Since he likes to make things perfect, he wants to arrange them from smallest to largest so that each statue will be bigger than the previous one exactly by 1. He may need some additional statues to be able to accomplish that. Help him figure out the minimum number of additional statues needed.

//For statues = [6, 2, 3, 8], the output should be makeArrayConsecutive2(statues) = 3.
// [2,3,*4*,*5*,6,*7*,8]

namespace Challenges.Algerbraic
{
    public class Statues
    {
        public static int makeArrayConsecutive2(int[] statues)
        {
            Array.Sort(statues);

            int missing = 0;

            for (int i = 1; i < statues.Length; i++)
                missing = missing + (statues[i] - statues[i - 1] - 1);
       
            return missing;
        }
    }
}

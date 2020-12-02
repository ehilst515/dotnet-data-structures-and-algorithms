using System.Collections.Generic;
using System.Linq;

namespace Challenges.Strings
{
   public class firstNonRepeatChar
    {
        public static char firstNotRepeatingCharacter(string s)
        {
            char[] charArray = s.ToCharArray();
            Dictionary<char, int> HT = new Dictionary<char, int>();
            char result = '_';

            for (int i = 0; i < charArray.Length; i++)
            {
                if (HT.ContainsKey(charArray[i]))
                    HT[charArray[i]] += 1;

                else HT.Add(charArray[i], 0);
            }

            if (!HT.ContainsValue(0))
               result = '_';

           else result = HT.FirstOrDefault(x => x.Value == 0).Key;

            return result;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.HashTable
{
    public class LeftJoin
    {
        public List<string[]> LeftJoiner(Dictionary<string, string> HT1, Dictionary<string, string> HT2)
        {
            var keyCollection1 = HT1.Keys;
            var keyCollection2 = HT2.Keys;

            List<string[]> result = new List<string[]>();

            for (int i = 0; i < keyCollection1.Count; i++)
            {
                string[] resultArray = new string[3];
                resultArray[0] = keyCollection1.ElementAt(i);
                resultArray[1] = Word(keyCollection1.ElementAt(i), HT1);
                resultArray[2] = Word(keyCollection1.ElementAt(i), HT2);
                result.Add(resultArray);
            }

            //for (int i = 0; i < result.Count; i++)
            //{
            //        if(result[i].Contains(keyCollection2.ElementAt(i)) == false)
            //        {
            //            string[] resultArray = new string[3];
            //            resultArray[0] = keyCollection2.ElementAt(i);
            //            resultArray[1] = null;
            //            resultArray[2] = Word(keyCollection2.ElementAt(i), HT2);
            //            result.Add(resultArray);
            //        }
            //}

            return result;
        }

        private string Word(string key, Dictionary<string, string> HT)
        {
            if (HT.TryGetValue(key, out string value))
                return value;

            else
                return null;
        }
    }
}

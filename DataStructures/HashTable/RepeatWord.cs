using DataStructures.HashTable;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.HashTable
{
    public class RepeatWord
    {
        private string[] phaseArr { get; set; }
        char[] delim = { ' ', ',', '.', ':', '\t' };
        public Dictionary<string, string> hashTable = new Dictionary<string, string>();
        public RepeatWord(string words)
        {
            phaseArr = words.Split(delim);
        }

        public string FirstWord()
        {
            foreach (string word in phaseArr)
            {
                if (hashTable.ContainsKey(word))
                    return word;
                else if (word != "")
                    hashTable.Add(word.ToLower(), word.ToLower());
            }

            return null;
        }
        
    }
}

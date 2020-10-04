using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.HashTable
{
    public class HashTable<TValue>
    {
        public static LinkedList<TValue>[] HT  = new LinkedList<TValue>[3];

        public static int GetHash(string key)
        {
            int[] keyNumArr = new int[key.Length];

            for (int i = 0; i < key.Length; i++)
                keyNumArr[i] = (int)key[i];

            int sum = 0;
            foreach (int n in keyNumArr)
                sum += n;

            int prime = 7;
            int hashNum = sum * prime;

            return hashNum;       
        }

        public void Add(string key, TValue value)
        {
            int bucketNum = GetHash(key) % HT.Length;
            LinkedListNode<TValue> newNode = new LinkedListNode<TValue>(value);
            if (HT[bucketNum] == null)
            {
                HT[bucketNum] = new LinkedList<TValue>();
                HT[bucketNum].AddFirst(newNode);
            }
            else
                HT[bucketNum].AddFirst(newNode);
        }

        public TValue HashFind(string key)
        {
            int hashNumber = GetHash(key);
            int bucketNumber = hashNumber % HT.Length;

            if (HT[bucketNumber] == null)
                throw new KeyNotFoundException();

            else
                return HT[bucketNumber].First();
        }
    }
      
}

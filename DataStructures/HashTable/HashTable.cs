using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.HashTable
{
    public class HashTable<TValue>
    {
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

        public static void Add(string key, TValue value, LinkedList<TValue>[] HT)
        {
            int bucketNum = GetHash(key) % HT.Length;
            var bucket = HT[bucketNum];

            if (bucket == null)
            {
                LinkedList<TValue> newLinkedList = new LinkedList<TValue>();
                newLinkedList.AddFirst(value);
            }

            else
                bucket.AddFirst(value);
        }

        public static string HashFind(string key, LinkedList<string>[] HT)
        {
            int hashNumber = GetHash(key);
            int bucketNumber = hashNumber % HT.Length;


            if (HT[bucketNumber] == null)
                return null;

            else
                return HT[bucketNumber].First();


        }

        public class Node<T>
        {
            public Node(T value, string key)
            {
                Value = value;
                Key = key;
            }

            // Hash Key
            public string Key { get; set; }
            // Value of this node
            public T Value { get; set; }
            // Pointer to the next node in the list
            public Node<T> Next { get; set; }

        }
    }
      
}

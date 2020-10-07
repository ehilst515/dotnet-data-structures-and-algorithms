using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class TreeIntersection<T>
    {


        public static List<int> TreeIntersect(BinaryTree<int> tree1, BinaryTree<int> tree2)
        {
            var hashTable = new Dictionary<int, int>();

            List<int> resultList = new List<int>();

            var list = tree1.Breadth_First();

            foreach (int num in list)
                hashTable.Add(num, num);
             
            var list2 = tree2.Breadth_First();

            foreach (int num in list2)
            {
                if (hashTable.ContainsKey(num))
                    resultList.Add(num);

                else
                    hashTable.Add(num, num);
            }

            return resultList;
        }
    }
}

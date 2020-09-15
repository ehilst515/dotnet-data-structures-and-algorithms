using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace DataStructures.Trees
{
    public class BinaryTree : BinarySearchTree
    {
        public int FindMaxValue(Node current)
        {
            if (current == null)
                return 0;

            int result = current.Value;

            int leftResult = FindMaxValue(current.Left);
            int rightResult = FindMaxValue(current.Right);

            if (leftResult > result)
                result = leftResult;
            if (rightResult > result)
                result = rightResult;

            return result;
        }
    }
}

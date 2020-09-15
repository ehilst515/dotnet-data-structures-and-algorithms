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

        public IEnumerable<int> Breadth_First() => Breadth_First_Helper(Root);


        IEnumerable<int> Breadth_First_Helper(Node current)
        {
            if (current == null)
                yield break;

            Queue<Node> queue = new Queue<Node>();
            Queue<Node> queueResult = new Queue<Node>();

            queue.Enqueue(current);
            while (queue.Count > 0)
            {
                Node DequeuedNode = queue.Dequeue();
                queueResult.Enqueue(DequeuedNode);

                if (DequeuedNode.Left != null)
                    queue.Enqueue(DequeuedNode.Left);

                if (DequeuedNode.Right != null)
                    queue.Enqueue(DequeuedNode.Right);
            }

            while (queueResult.Count > 0)
                yield return queueResult.Dequeue().Value;              
        }
    }
}

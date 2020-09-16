using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public string PreOrder(StringBuilder sb, Node node)
        {
            if (node != null)
            {
                sb.Append(node.Value);
                sb.Append(" ");
                PreOrder(sb, node.Left);
                PreOrder(sb, node.Right);
            }
            string result = sb.ToString();

            return result.Remove(result.Length - 1, 1);
        }

        public string InOrder(StringBuilder sb, Node node)
        {
            if (node != null)
            {
                InOrder(sb, node.Left);
                sb.Append(node.Value);
                sb.Append(" ");
                InOrder(sb, node.Right);
            }

            string result = sb.ToString();

            return result.Remove(result.Length - 1, 1);
        }

        public string PostOrder(StringBuilder sb, Node node)
        {
            if (node != null)
            {
                PostOrder(sb, node.Left);
                PostOrder(sb, node.Right);
                sb.Append(node.Value);
                sb.Append(" ");
            }

            string result = sb.ToString();

            return result.Remove(result.Length - 1, 1);
        }

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

        private IEnumerable<int> Breadth_First_Helper(Node current)
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
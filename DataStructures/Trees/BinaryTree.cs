using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        public string PreOrder(StringBuilder sb, Node<T> node)
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

        public string InOrder(StringBuilder sb, Node<T> node)
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

        public string PostOrder(StringBuilder sb, Node<T> node)
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

        public IEnumerable<T> Breadth_First() => Breadth_First_Helper(Root);

        private IEnumerable<T> Breadth_First_Helper(Node<T> current)
        {
            if (current == null)
                yield break;

            var queue = new Queue<Node<T>>();
            var queueResult = new Queue<Node<T>>();

            queue.Enqueue(current);
            while (queue.Count > 0)
            {
                var DequeuedNode = queue.Dequeue();
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
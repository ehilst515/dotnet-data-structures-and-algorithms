using System;
namespace DataStructures.StacksAndQueues
{
    public class Queue<T>
    {
        public class Node
        {
            public Node(T value)
            {
                Value = value;
            }
            // Value of this node
            public T Value { get; set; }
            // Pointer to the next node in the list
            public Node Next { get; set; }
        }

        public Node Front { get; set; }
        public Node Rear { get; set; }

        public void Enqueue(T value)
        {
            Node node = new Node(value);
            if (Front == null)
            {
                node.Next = node;
                Front = node;
            }
            else
            {
                node.Next = node;
                Rear = node;
            }
        }

        public T Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
        }

        public T QPeek()
        {
            if (Front == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return Front.Value;
            }
        }

        public bool QIsEmpty()
        {
            if (Front == null)
            {
                return true;
            }
            else
                return false;
        }
    }
}

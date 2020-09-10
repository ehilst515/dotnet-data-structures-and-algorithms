using System;
namespace DataStructures.StacksAndQueues
{
    public class Stack<T>
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

        public Node Top { get; set; }

        // Stacking
        public void Push(T value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        public T Pop()
        {
            if (Top == null)
                throw new InvalidOperationException();

            else
            {
                Node temp = Top;
                Top = temp.Next;
                temp.Next = null;
                return temp.Value;
            }
        }

        public T Peek()
        {
            if(Top == null)
                throw new InvalidOperationException();
            
            else
                return Top.Value;
        }

        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;
            }

            else
                return false;
        }
    }
}

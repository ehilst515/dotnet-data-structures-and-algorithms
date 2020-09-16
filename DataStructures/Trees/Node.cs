namespace DataStructures.Trees
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        // Value of this node
        public T Value { get; set; }

        // Pointer to the next node in the list
        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }
    }
}
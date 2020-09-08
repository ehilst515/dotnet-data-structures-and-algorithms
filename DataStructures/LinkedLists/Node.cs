namespace DataStructures
{
    public class Node
    {
        private string stringValue;

        public Node(int value)
        {
            Value = value;
        }

        // Value of this node
        public int Value { get; set; }

        // Pointer to the next node in the list
        public Node Next { get; set; }
    }
}
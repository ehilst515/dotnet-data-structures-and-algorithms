namespace DataStructures
{
    public class Node
    {
        private string stringValue;

        public Node(int value)
        {
            Value = value;
        }

        public Node(string stringValue)
        {
            this.stringValue = stringValue;
        }

        // Value of this node
        public int Value { get; set; }

        // Pointer to the next node in the list
        public Node Next { get; set; }
    }
}
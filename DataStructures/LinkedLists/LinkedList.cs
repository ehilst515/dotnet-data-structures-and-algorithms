namespace DataStructures.LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public bool Includes(int value)
        {
            Node current = Head;
            int input = value;
            while (current != null)
            {
                if (current.Value == input)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public override string ToString()
        {
            Node current = Head;
            string result = "";
            while (current != null)
            {
                result += $"{{ {current.Value} }} -> ";
                current = current.Next;
            }
            return result + "NULL";
        }
    }
}
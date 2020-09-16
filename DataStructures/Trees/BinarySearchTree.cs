namespace DataStructures.Trees
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (Root == null)
                Root = newNode;
            else
            {
                Node current = Root;
                Node Prev;
                while (true)
                {
                    Prev = current;

                    if (value < current.Value) //go left
                    {
                        current = current.Left;

                        if (current == null) //add new node if left is null
                        {
                            Prev.Left = newNode;
                            return;
                        }
                    }
                    else //go right
                    {
                        current = current.Right;

                        if (current == null) //add new node if Right is null
                        {
                            Prev.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public bool Contains(Node current, int value)
        {
            if (Root == null || current == null)
                return false;
            else
            {
                if (current.Value == value)
                    return true;
                else if (value < current.Value)
                    return Contains(current.Left, value);
                else
                    return Contains(current.Right, value);
            }
        }
    }
}
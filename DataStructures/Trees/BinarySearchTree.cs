namespace DataStructures.Trees
{
    public class BinarySearchTree : NumberTree
    {
        public void Add(int value)
        {
            var newNode = new Node<int>(value);

            if (Root == null)
                Root = newNode;
            else
            {
                var current = Root;
                Node<int> Prev;
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

        // public bool Contains(int value) => Contains(Root, value);

        public bool Contains(Node<int> current, int value)
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
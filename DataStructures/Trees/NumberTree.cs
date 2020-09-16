namespace DataStructures.Trees
{
    public class NumberTree : BinaryTree<int>
    {
        public int FindMaxValue(Node<int> current)
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
    }
}
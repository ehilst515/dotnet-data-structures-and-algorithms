namespace DataStructures.Trees
{
    public class FizzBuzzTree : BinaryTree<string>
    {
        // Input:
        //     4
        //   3    5
        // 1  2     6
        //            10
        //               15

        // Output:
        //           4
        //    Fizz      Buzz
        //  1     2          Fizz
        //                      Buzz
        //                         FizzBuzz 

        public static BinaryTree<string> FizzBuzz(BinaryTree<int> numberTree) 
        {
            if (numberTree.Root == null)
                return null;
            if (numberTree.Root.Value.GetType() != typeof(int))
                return null;

            Node<int> current = numberTree.Root;
            BinaryTree<string> resultTree = new BinaryTree<string>();

            resultTree.Root = new Node<string>(FizzBuzzConverter(current.Value));
            if (current.Left != null)
            {
                resultTree.Root.Left = new Node<string>(FizzBuzzConverter(current.Left.Value));
                FizzBuzzBuilder(current.Left, resultTree.Root.Left, resultTree);
            }
            if (current.Right != null)
            {
                resultTree.Root.Right = new Node<string>(FizzBuzzConverter(current.Right.Value));
                FizzBuzzBuilder(current.Right, resultTree.Root.Right, resultTree);
            }

            return resultTree;
        }


        public static BinaryTree<string> FizzBuzzBuilder(Node<int> current, Node<string> stringNode, BinaryTree<string> resultTree)
        {
            Node<string> prev = stringNode;

            if (current.Left != null)
            {
                stringNode.Left = new Node<string>(FizzBuzzConverter(current.Left.Value));
                FizzBuzzBuilder(current.Left, stringNode.Left, resultTree);
            }
            if (current.Right != null)
            {
                stringNode.Right = new Node<string>(FizzBuzzConverter(current.Right.Value));
                FizzBuzzBuilder(current.Right, stringNode.Right, resultTree);
            }

            if (current.Right == null && current.Left == null)
                prev.Value = FizzBuzzConverter(current.Value);

            return resultTree;
        }

        public static string FizzBuzzConverter(int number)
        {   
            if (number % 3 == 0 && number % 5 == 0)
                        return "FizzBuzz";

                else if (number % 3 == 0)
                        return "Fizz";

                else if (number % 5 == 0)
                        return "Buzz";

                else return number.ToString();
        }
    }
}
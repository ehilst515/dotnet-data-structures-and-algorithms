using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace DataStructures.Trees
{
    class FizzBuzzTree : BinaryTree<string>
    {
        //     4
        //   3    5
        // 1  2     6
        //            10
        //               15

        //           4
        //    Fizz      Buzz
        //  1     2          Fizz
        //                      Buzz
        //                         FizzBuzz 



        public void FizzBuzz(BinaryTree<int> numberTree) //need to return BinaryTree<string>
        {
            Node<int> current = numberTree.Root;

            BinaryTree<string> stringTree = new BinaryTree<string>();

            stringTree.Root = new Node<string>(FizzBuzzConverter(current.Value));

            if(Root.Left != null)
            {
                stringTree.Root.Left = new Node<string>(FizzBuzzConverter(current.Left.Value));

            }


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
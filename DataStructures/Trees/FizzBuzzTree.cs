using System.Collections.Generic;
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



        public void FizzBuzz(BinaryTree<int> numberTree) // need to return a BinaryTree<string>
        {
            Node<int> current = numberTree.Root;

            BinaryTree<string> stringTree = new BinaryTree<string>();

            stringTree.Root = new Node<string>(FizzBuzzConverter(current.Value));


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
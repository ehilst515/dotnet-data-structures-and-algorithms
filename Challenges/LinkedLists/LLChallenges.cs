using DataStructures;
using DataStructures.LinkedLists;

namespace Challenges.LinkedLists
{
    public class LLChallenges
    {
        public static LinkedList Zipper(LinkedList listOne, LinkedList listTwo)
        {
            Node currOne = listOne.Head;
            Node currTwo = listTwo.Head;

            LinkedList result = new LinkedList();

            while(currOne != null || currTwo != null)
            {

                if (currTwo != null)
                {
                    result.Append(currTwo.Value);
                    currTwo = currTwo.Next;
                }

                if (currOne != null)
                {
                    result.Append(currOne.Value);
                    currOne = currOne.Next;
                }

            }

            return result;
        }
    }
}

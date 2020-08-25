using System;
namespace Challenges.tests.Arrays
{
    public class ArrayShift
    {

        public static int[] insertShiftArray(int[] inputArray, int input)
            {
                int n = inputArray.Length;

                int pos;

                if(n % 2 == 0)
                {
                pos = inputArray.Length / 2 + 1;
                }
                else
                {
                pos = inputArray.Length / 2 + 2;
                }

                int[] outputArray = new int[n + 1];

                for(int i = 0; i < n + 1; i++)
                {
                    if(i < pos - 1)
                    {
                        outputArray[i] = inputArray[i];
                    }

                    else if(i == pos - 1){
                        outputArray[i] = input;
                    }

                    else
                    {
                        outputArray[i] = inputArray[i - 1];
                    }

                }

                return outputArray;
            }
    }
}

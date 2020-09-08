using System;
namespace Challenges.Arrays
{
    public class Reverse
    {
       public static int[] ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tempValue = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tempValue;
            }

            return array;
        }
    }
}

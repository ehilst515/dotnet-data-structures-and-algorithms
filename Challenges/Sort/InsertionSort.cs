﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Sort
{
    public class InsertionSort
    {
        public static int[] Insertion(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
 
}


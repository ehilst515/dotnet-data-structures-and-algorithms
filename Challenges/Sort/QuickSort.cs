﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Sort
{
    class QuickSort
    {
        public static int[] QuickSorter(int[] arr)
        {
            QuickSorter(arr, 0, arr.Length - 1);
            return arr;
        }
        public static void QuickSorter(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    QuickSorter(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSorter(arr, pivot + 1, right);
                }
            }
        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (arr[left] == arr[right])
                        return right;
                    int i = arr[left];
                    arr[left] = arr[right];
                    arr[right] = i;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}

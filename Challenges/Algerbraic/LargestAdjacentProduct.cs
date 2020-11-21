using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Algerbraic
{
    public class LargestAdjacentProduct
    {
        public static int AdjacentElementsProduct(int[] inputArray)
        {
            int largestProduct = 0;

            for (int i = 1; i < inputArray.Length; i++)
            {
                int currentProduct = inputArray[i] * inputArray[i - 1];
                if (currentProduct > largestProduct)
                    largestProduct = currentProduct;
            }

            return largestProduct;

        }
    }
}

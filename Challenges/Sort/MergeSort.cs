namespace Challenges.Sort
{
    public class MergeSort
    {
        public static int[] MergeSorter(int[] arr)
        {
            int[] leftArr;
            int[] rightArr;
            int[] result = new int[arr.Length];

            if (arr.Length <= 1)
                return arr;

            int mid = (arr.Length / 2);

            leftArr = new int[mid];

            if (arr.Length % 2 == 0)
                rightArr = new int[mid];
            else
                rightArr = new int[mid + 1];

            for (int i = 0; i < mid; i++)
                leftArr[i] = arr[i];

            int x = 0;

            for (int i = mid; i < arr.Length; i++)
            {
                rightArr[x] = arr[i];
                x++;
            }

            leftArr = MergeSorter(leftArr);
            rightArr = MergeSorter(rightArr);
            result = Merge(leftArr, rightArr);
            return result;

        }

        public static int[] Merge(int[] leftArr, int[] rightArr)
        {
            int resultLength = leftArr.Length + rightArr.Length;
            int[] result = new int[resultLength];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < leftArr.Length || j < rightArr.Length)
            {
                if (i < leftArr.Length && j < rightArr.Length)
                {
                    if (leftArr[k] <= rightArr[j])
                    {
                        result[k] = leftArr[i];
                        i++;
                        k++;
                    }
                    else
                    {
                        result[k] = rightArr[j];
                        j++;
                        k++;
                    }
                }
                else if (i == leftArr.Length - 1)
                {
                    result[k] = leftArr[i];
                    i++;
                    k++;
                }
                else if (j == rightArr.Length - 1)
                {
                    result[k] = rightArr[j];
                    j++;
                    k++;
                }
            }
            return result;
        }
    }
}
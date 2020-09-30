# Merge Sort

**Merge Sort** splits an array into half sized sub-arrays until they are pair values. It then sorts and swaps pairs values if needed. The sorting process continues on all of the sub-arrays, combining the smaller arrays until the full list is merged.

## Pseudocode
```
  InsertionSort(int[] arr)
  
    FOR i = 1 to arr.length
    
      int j <-- i - 1
      int temp <-- arr[i]
      
      WHILE j >= 0 AND temp < arr[j]
        arr[j + 1] <-- arr[j]
        j <-- j - 1
        
      arr[j + 1] <-- temp

```

## Trace

Sample Array: 

Input: `[8,4,23,42,16,15]`
1. The array is split in half: `[8,4,23][42,16,15]`
2. The two sub-arrays are split again: `[8,4][23][42,16][15]`
3. The sub-arrays are sorted: `[4,8][23][16,42][15]`
4. The pair value sub-arrays are merged and sorted with their adjacent sub-array: `[4,8,23][15,16,42]`
5. The two halves of the array are merged and sorted: `[4,8,15,16,23,42]`

Output: `[4,8,15,16,23,42]`

## Efficiency
Time: O(n*log n)

Time complexity of Merge Sort is O(n*Log n) as merge sort always divides the array in two halves and takes linear time to merge two halves.


Space: O(n)

No additional space is being created. This array is being sorted in place keeping the space at constant O(1).
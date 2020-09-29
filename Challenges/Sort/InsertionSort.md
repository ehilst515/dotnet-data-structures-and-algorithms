# Insertion Sort

**Insertion Sort** to sort from smallest to largest value works by starting with assuming the first value in the array is the smallest in the array. It then compares each value in the array to the value to its left. If the current value is smaller than the one on its left, it will insert the current value to the left of the checked value. 

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

1st pass: [8,**4**,23,42,16,15]

On the first pass, we check to see if 4 is smaller than 8. It is, so 4 becomes the left most value.

2nd pass: [4,8,**23**,42,16,15]

On the second pass, we check to see if 23 is less than 8. It is not, so it's inserted back where it was found.

3rd pass: [4,8,23,**42**,16,15]

The third pass is similar to the second.

4th: [4,8,23,42,**16**,15]

On the fourth pass, 16 is checked against 42, moved to the left, against 23, moved to the left, then against 8 and 16 is greater than 8. It is then inserted to the right of 8.

5th: [4,8,16,23,42,**15**]

The fifth pass is similar to the fourth.

Output: `[4,8,15,16,23,42]`

## Efficiency
Time: O(n^2)

The basic operation of this algorithm is comparison. This will happen n * (n-1) number of times…concluding the algorithm to be n squared.


Space: O(1)

No additional space is being created. This array is being sorted in place…keeping the space at constant O(1).
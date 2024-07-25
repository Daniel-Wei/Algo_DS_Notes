### 冒泡排序

- Time Complexity; Avg - O(n^2), Best - O(n), Worst - O(n^2)
- Space Complexity: O(1)
- Stable: True 因为不会swap相等元素之间的位置

```java
public int[] bubbleSort(int[] nums) {
    int n = nums.length;
    
    // i < n - 1 因为只需要bubble sort n - 2次
    for(int i = 0; i < n - 1; i++){
        boolean alreadySorted = true;
        
        // j < n - 1 - j 因为bubble sort每次少compare一次
        for(int j = 0; j < n - 1 - i; j++){
            if(nums[j] > nums[j+1]){
                int temp = nums[j];
                nums[j] = nums[j+1];
                nums[j+1] = temp;
                alreadySorted = false;
            }
        }

        // Best Time Complexity: O(n)
        // As if the nums array is already sorted, the outer loop will terminate after one iteration of the inner loop.
        if(alreadySorted){
            break;
        }
    }
    
    return nums;
}

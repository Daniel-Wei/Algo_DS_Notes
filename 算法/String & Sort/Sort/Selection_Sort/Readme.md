### 选择排序

- Time Complexity: Avg - O(n^2), Best - O(n^2), Worst - O(n^2)
- Space Complexity: O(1)
- Stable: False
  - Example:[5,5,2]
  - After the first iteration, the first '5' will be swapped with '2', resulting in the first '5' is now after the second '5'.


```java
public int[] sortArray(int[] nums) {
    int n = nums.length;
    
    // i < n - 1因为selection sort只需要进行n-1次
    for(int i = 0; i < n - 1; i++){
        int minIndex = i;
        
        for(int j = i + 1; j < n; j++){
            if(nums[j] < nums[minIndex]){
                minIndex = j;
            }
        }
        
        int temp = nums[i];
        nums[i] = nums[minIndex];
        nums[minIndex] = temp;
    }
    
    return nums;
}

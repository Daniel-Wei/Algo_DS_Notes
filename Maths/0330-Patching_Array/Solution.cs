// Time: 68 ms (100.00%), Space: 42.2 MB (37.50%)


public class Solution {

    // Example: nums = [1, 2, 5], n = 10
    // Loop one: currMax = 1, i = 1; [1, 1]
    // Loop two: currMax = 3, i = 3; [1, 3]
    // Loop three: currMax = 7, res = 1, addedNums = [4], i = 3; 
    //     As we know 4 is the missing to be added on, previous possible sums is [1, 3], now possible sums is [1, 7]
    // Loop four: currMax = 12, res = 1, addNums = [4], end

    public int MinPatches(int[] nums, int n) {
        int i = 0;
        long currMax = 0;
        int res = 0;
        
        while(currMax < n){
            if(i < nums.Length && nums[i] <= currMax + 1){
                currMax += nums[i];
                i++;
            }else{
                currMax += currMax + 1;
                res++;
            }
        }
        
        return res;
    }
}

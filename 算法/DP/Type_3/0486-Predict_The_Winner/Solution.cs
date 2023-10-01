Time: 82 ms (85.63%), Space: 40 MB (55.09%)

public class Solution {
    public bool PredictTheWinner(int[] nums) {
        int n = nums.Length;
        int totalSum = nums.Sum();
        //dp[i, j] = max sum when choose from nums[i..j] as the first hand
        int[ , ]dp = new int[n, n];
        
        for(int i = 0; i < n; i++){
            int currSum = nums[i];
            for(int j = i; j >= 0; j--){
                if(i == j){
                    dp[i, i] = nums[i];
                    
                }else{
                    currSum += nums[j];
                    dp[j, i] = Math.Max(currSum - dp[j + 1, i], currSum - dp[j, i - 1]);
                }
            }
        }
        
        return 2 * dp[0, n - 1] >= totalSum;
    }
}

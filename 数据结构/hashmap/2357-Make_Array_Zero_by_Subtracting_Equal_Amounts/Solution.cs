// Time: 64 ms (39.38%), Space: 40.4 MB (65.28%)

public class Solution {
    public int MinimumOperations(int[] nums) {
        HashSet<int> hs = new HashSet<int>();

        foreach(int num in nums){
            if(num != 0 && !hs.Contains(num)){
                hs.Add(num);
            }
        }
        
        return hs.Count;
    }
}

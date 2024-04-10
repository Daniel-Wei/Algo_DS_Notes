// Time: 345 ms (21.90%), Space: 77.9 MB (24.08%)

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int l = 0;
        int r = 0;
        int curr = 0;
        int sum = 0;
        IList<IList<int>> res = new List<IList<int>>();
        Dictionary<int, HashSet<int>> dict = new Dictionary<int, HashSet<int>>();
        
        for(int i = 0; i < nums.Length - 2; i++){
            l = i + 1;
            r = nums.Length - 1; // restore init pos of right pointer
            curr = nums[i];

            while(l < r){
                sum = nums[l] + nums[r];

                if(sum > -curr){
                    r -= 1;
                }else if(sum == -curr){
                    if(!dict.ContainsKey(curr)){
                        dict.Add(curr, new HashSet<int>{nums[l]});
                        res.Add(new List<int>{curr, nums[l], nums[r]});
                    }else{
                        
                        // Avoid duplicate triplets
                        if(!dict[curr].Contains(nums[l])){
                            dict[curr].Add(nums[l]);
                            res.Add(new List<int>{curr, nums[l], nums[r]});
                        }
                    }
                    l += 1;
                }else{
                    l += 1;
                }
            }
            
           
        }
        
        return res;
    }
}

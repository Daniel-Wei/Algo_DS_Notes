// Time: 34 ms (37.75%), Space: 28.6 MB (73.29%)

public class Solution {
    public bool IsPerfectSquare(int num) {
        int l = 0;
        int r = num;
        
        while(l <= r){
            int mid = (l + r) / 2;
            long curr = (long)mid * mid;
            
            if(curr > num){
                r = mid - 1;
            }else if(curr < num){
                l = mid + 1;
            }else{
                return true;
            }
        }
        
        return false;
    }
}

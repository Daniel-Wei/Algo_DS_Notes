// Time: 1 ms (99.42%), Space: 42.7 MB (5.90%)

class Solution {
    public int minOperations(String[] logs) {
        int res = 0;
        
        for(String log: logs){
            int n = log.length();
            char c = log.charAt(n - 2);
            
            // log is "x/"
            if(c != '.'){
                res += 1;
                
            // log is "../"
            // notice: res -= 1 only when we are not at the root folder
            }else if(n != 2 && res > 0){
                res -= 1;
            }
        }
        
        return res;
    }
}

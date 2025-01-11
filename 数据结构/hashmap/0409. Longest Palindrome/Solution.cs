// Time: 36 ms (97.92%), Space: 38.4 MB (50.43%)

public class Solution {
    public int LongestPalindrome(string s) {
        int res = 0;
        
        Dictionary<char, int> dict = new Dictionary<char, int>();
        
        foreach(char c in s){
            if(dict.ContainsKey(c)){
                dict[c]++;
            }else{
                dict.Add(c, 1);
            }
        }
        
        bool hasOddFreq = false;
        
        foreach(int freq in dict.Values){
            if(freq % 2 == 0){
                res += freq;
            }else{
                res += freq - 1;
                hasOddFreq = true;
            }
        }
        
        if(hasOddFreq){
            res += 1;
        }
        
        return res;
    }
}

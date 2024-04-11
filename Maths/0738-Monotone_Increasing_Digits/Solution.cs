// Time: 9 ms (100.00%), Space: 27.4 MB (35.71%)

// Reverse Order
// When digit[i] > digit[i-1], set digit[i] = 9 and digit[i-1] -= 1
// For last such i to the start(actual digit of int n), all set to be 9
public class Solution {
    public int MonotoneIncreasingDigits(int n) {
        List<int> l = new List<int>();
        
        while(n > 0){
            l.Add(n % 10);
            n /= 10;
        }
        
        int stop = -1;
    
        for(int i = 0; i < l.Count - 1; i++){
            if(l[i] < l[i+1]){
                l[i] = 9;
                l[i+1] -= 1;
                stop = i;
            }
        }
        
        for(int i = 0; i <= stop; i++){
            l[i] = 9;
        }
        
        l.Reverse();
        
        int total = 0;
        foreach (int entry in l)
        {
            total = 10 * total + entry;
        }
        
        return total;
    }
}

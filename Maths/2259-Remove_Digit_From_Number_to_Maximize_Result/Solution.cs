// Time: 59 ms (85.71%), Space: 41.5 MB (65.48%) 

// Simply check next number
public class Solution {
    public string RemoveDigit(string number, char digit) {
        int index = -1;
        for(int i = 0; i < number.Length; i++){
            if(number[i] == digit){
                index = i;
                
                if(i < number.Length - 1 && number[i] < number[i+1]){
                    break;
                }
            }
        }
        
        return number.Remove(index, 1);
    }
}

// Time: 78 ms (39.76%), Space: 42.4 MB (89.16%)

public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        Array.Sort(seats);
        Array.Sort(students);
        
        int res = 0;
        
        for(int i = 0; i < seats.Length; i++){
            res += Math.Abs(seats[i] - students[i]);
        }
        
        return res;
    }
}

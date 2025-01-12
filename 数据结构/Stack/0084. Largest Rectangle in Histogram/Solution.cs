// Time: 299 ms (81.21%), Space: 52.4 MB (89.42%)

public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> s = new Stack<int>();
        int res = 0, h = 0, last = 0, w = 0;
        
        for(int i = 0; i <= heights.Length; i++){
            
            //Make sure all elements pop out, avoid cases like 
            h = i == heights.Length ? 0 : heights[i];
            
            while(s.Any() && h < heights[s.Peek()]){
                last = s.Pop();
                
                //if stack is empty: such heights[last] is all over
                w = s.Any()? i - s.Peek() - 1 : i;
                res = Math.Max(res, heights[last] * w);
            }
            s.Push(i);
        }
        
        return res;
    }
}

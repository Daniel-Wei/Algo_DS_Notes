// Time: 436 ms (26.73%), Space: 46.4 MB (37.34%)

class Solution {
    public String removeStars(String s) {
        Stack<Character> stack = new Stack<Character>();
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i < s.length(); i++){
            char c = s.charAt(i);
            if(c == '*'){
                stack.pop();
            }else{
                stack.push(c);
            }
        }
        
        while(stack.size() > 0){
            sb.insert(0, stack.pop());
        }
        
        return sb.toString();
    }
}

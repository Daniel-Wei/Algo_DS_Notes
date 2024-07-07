// Time: 0 ms (100.00%), Space: 40.6 MB (61.39%)

class Solution {
    public int maxBottlesDrunk(int numBottles, int numExchange) {
        int res = numBottles;
        int k = numBottles;
        int e = numExchange;
        
        while(k >= e){
            k-=e;
            e++;
            k++;
            res++;
        }
        
        return res;
    }
}

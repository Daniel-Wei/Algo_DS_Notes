// Time: 0 ms (100.00%), Space: 40.1 MB (54.33%) 

class Solution {
    public int numWaterBottles(int numBottles, int numExchange) {
        int k = numBottles / numExchange;
        int m = numBottles % numExchange;
        int bottles = k + m;
        int res = k + numBottles;
        
        while(bottles >= numExchange){
            k = bottles / numExchange;
            m = bottles % numExchange;
            res += k;
            bottles = k + m;
        }
        
        return res;
    }
}

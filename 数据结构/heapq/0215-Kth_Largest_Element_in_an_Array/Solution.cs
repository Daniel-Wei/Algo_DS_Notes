// Time: 370 ms (57.32%), Space: 56.5 MB (52.46%)

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        
        foreach(int num in nums){
            pq.Enqueue(num, -num); // make minHeap to be maxHeap: larger numbers, lower priorities
        }
        
        while(k > 1){
            pq.Dequeue();
            k--;
        }
        
        return pq.Dequeue();
    }
}

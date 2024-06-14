import heapq

class Solution:
    def kClosest(self, points: List[List[int]], k: int) -> List[List[int]]:
        
        h = []
        
        for p in points:
            heapq.heappush(h, (p[0] ** 2 + p[1] ** 2, p))
        
        return [item[1] for item in heapq.nsmallest(k, h)]

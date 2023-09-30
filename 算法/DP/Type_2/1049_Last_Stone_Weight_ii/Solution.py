#should be delated

class Solution:
    def lastStoneWeightII(self, stones: List[int]) -> int:
        memo = [set() for _ in range(len(stones))]
        
        memo[0].add(stones[0])
        
        for i in range(1, len(stones)):
            curr = stones[i]
            
            # 每个新stone val都可能被加上或者减去
            # 最终结果是non-negative 所以要用abs
            for prev in memo[i - 1]:
                p1 = abs(prev + curr)
                p2 = abs(prev - curr)
                
                # 使用set() 避免MLE
                memo[i].add(p1)
                memo[i].add(p2)
                
        return min(memo[-1])

class Solution:
    def partitionLabels(self, s: str) -> List[int]:
        last = {}
        res = []
        
        # hashtable[char] = char的最右index
        for i, char in enumerate(s):
            last[char] = i
            
        l, r = 0, 0
        
        for i, char in enumerate(s):
            
            # 持续更新为所有遍历过的char的最右出现位置
            r = max(r, last[char])
            
            # 当前位置恰好是所有遍历过的char的最右出现位置
            if i == r:
                res += [r - l + 1] # 进行切割
                l = r + 1 # 重新准备下一次切割
                
        return res

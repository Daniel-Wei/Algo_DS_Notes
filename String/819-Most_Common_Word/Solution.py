class Solution:
    def mostCommonWord(self, paragraph: str, banned: List[str]) -> str:
        
        # 去除所有标点符号，但是仍然要保留所有空格，因为后续需要空格来分隔单词
        paragraph = ''.join(' ' if c in string.punctuation else c for c in paragraph).lower()
        
        for word in set(banned):
            paragraph = paragraph.replace(word, "")
        
        # 根据空格分隔单词
        words = paragraph.split()
        freq = {}
        
        
        for word in words:
            if word in freq:
                freq[word] += 1
            else:
                freq[word] = 1
               
        h = []
        for word in set(words):
            heapq.heappush(h, (freq[word], word))
            
        return heapq.nlargest(1, h)[0][1]

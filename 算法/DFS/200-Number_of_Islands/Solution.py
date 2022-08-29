# 思路来源：花花酱 
# https://www.youtube.com/watch?v=XSmgFKe-XYU

# 1. 孤立每一座小岛，dfs其周围的陆地，直至到水面
# 2. 讲所有visited islands都改为水面


class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        if not grid:
            return 0

        self.g = grid

        ans = 0
        self.m = len(grid)
        self.n = len(grid[0])

        def dfs(i, j):

          # 如果没有到边界 而且还是陆地
            if not (i >= self.m or j >= self.n or i < 0 or j < 0 or self.g[i][j] == '0' ):
                self.g[i][j] = '0'

                dfs(i, j + 1)
                dfs(i, j - 1)
                dfs(i + 1, j)
                dfs(i - 1, j)

        for i in range(self.m):
            for j in range(self.n):
                if self.g[i][j] == '1':
                    ans += 1
                    dfs(i, j)

        return ans

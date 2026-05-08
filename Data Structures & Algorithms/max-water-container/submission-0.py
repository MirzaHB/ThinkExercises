class Solution:
    def maxArea(self, heights: List[int]) -> int:
        maxArea = 0

        r = len(heights)-1
        l = 0

        while r>l:
            shortSide = min(heights[l],heights[r])
            maxArea = max(maxArea,shortSide * (r-l))
            if heights[l]>heights[r]:
                r-=1
            else:
                l+=1
        return maxArea
        
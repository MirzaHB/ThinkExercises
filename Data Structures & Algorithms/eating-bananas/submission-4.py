class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        def canFinish(k):
            t=0
            ban = piles.copy()
            for i in range(len(ban)):
                t += -(-ban[i] // k)
            return t<=h
        
        l=1
        r=sum(piles)
        res=0
        while l<=r:
            m = (r+l)//2
            if canFinish(m):
                res=m
                r=m-1
            else:
                l=m+1
        return res

class Solution:
    def shipWithinDays(self, weights: List[int], days: int) -> int:
        total = sum(weights)
        biggest = total
        smallest = max(weights)

        def helper(num):
            count = 1
            currcap = num

            for w in weights:
                if currcap - w<0:
                    count +=1
                    if count>days:
                        return False
                    currcap = num
                currcap-=w
            return True
        
        l= smallest
        r = biggest
        res=r
        while l<=r:
            m = (l+r)//2

            if helper(m):
                res = min(res,m)
                r=m-1
            else:
                l=m+1
        return res

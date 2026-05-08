class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        
        count = {}
        longest=0
        l=0
        res = 0
        for r in range(len(s)):
            count[s[r]]= 1 + count.get(s[r],0)

            if (r-l+1) - max(count.values())-k <=0:
                res = max(res, r-l+1)
            else:
                while (r-l+1) - max(count.values())-k>0:
                    count[s[l]] = count.get(s[l]) - 1
                    l+=1
        return res 
class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        maxSize = 0
        currSize = 0
        inString = set()
        L = 0

        for r in range(len(s)):
            while s[r] in inString:
                inString.remove(s[L])
                L +=1
            
            inString.add(s[r])
            currSize = r - L + 1
            maxSize = max(maxSize, currSize)
        
        return maxSize


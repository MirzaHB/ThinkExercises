class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        uniqueSet = set()
        Lptr = 0
        Length = 0
        currlen = 0

        for letter in s:
            while letter in uniqueSet:
                currlen -=1
                uniqueSet.remove(s[Lptr])
                Lptr += 1
            uniqueSet.add(letter)
            currlen+=1
            Length = max(Length, currlen)
        return Length


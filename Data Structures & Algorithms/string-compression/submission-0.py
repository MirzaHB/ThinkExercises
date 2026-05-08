class Solution:
    def compress(self, chars: List[str]) -> int:
        l=0
        count = 0
        for r in range(len(chars)):
            if chars[l]==chars[r]:
                count +=1
            if chars[l]!=chars[r]:
                l+=1
                if count > 1:
                    for digit in str(count):
                        chars[l] = digit
                        l += 1
                chars[l] = chars[r]
                count = 1
            if r==len(chars)-1 and chars[l]!=chars[r]:
                l+=1
                chars[l] = chars[r]
                if count>1:
                    for digit in str(count):
                        l += 1
                        chars[l] = digit
            elif chars[r]==chars[l] and r==len(chars)-1:
                if count>1:
                    for digit in str(count):
                        l += 1
                        chars[l] = digit
        return l+1
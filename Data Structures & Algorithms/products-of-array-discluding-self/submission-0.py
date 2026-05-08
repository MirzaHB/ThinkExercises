class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        postfix = []
        prefix = []
        total = 1
        for n in nums:
            total*=n
            prefix.append(total)
        i = len(nums)-1
        total = 1
        while i>=0:
            total*= nums[i]
            postfix.append(total)
            i-=1
        postfix = postfix[::-1]
        ans = []
        for k in range(len(nums)):
            left = prefix[k-1] if k>0 else 1
            right = postfix[k+1] if k<len(nums)-1 else 1
            ans.append((left*right))
        return ans

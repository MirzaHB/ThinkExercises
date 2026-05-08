class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        pre = [1]
        post = []
        multiplyer = 1

        for n in nums:
            multiplyer*=n
            pre.append(multiplyer)
        
        post = [1] * len(nums)
        multiplyer = 1
        i = len(nums)-1
        while i>=0:
            post[i] = multiplyer
            multiplyer*=nums[i]
            i-=1
        
        ans=[]
        for i in range(len(nums)):
            right = pre[i] if i < len(pre) else 1      # Changed from pre[i+1] to pre[i]
            left = post[i] if i < len(post) else 1
            ans.append(right * left)
        return ans
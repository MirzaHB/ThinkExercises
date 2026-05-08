class Solution:
    def findPeakElement(self, nums: List[int]) -> int:
        l,r = 0, len(nums)-1
        m = 0
        if len(nums)==2:
            return 0 if nums[1]<nums[0] else 1
        while l<=r:
            m = (l+r)//2
            if m > 0 and nums[m - 1] > nums[m]:
                r = m - 1      
            elif m < len(nums) - 1 and nums[m + 1] > nums[m]:
                l = m + 1
            else:
                return m
            
            
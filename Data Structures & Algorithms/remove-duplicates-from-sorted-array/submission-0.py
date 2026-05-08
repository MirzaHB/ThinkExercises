class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        dupeck=set()
        l=0

        for r in range(len(nums)):
            if nums[r] not in dupeck:
                nums[l]= nums[r]
                l+=1
            dupeck.add(nums[r])
        return l
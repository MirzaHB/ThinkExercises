class Solution:
    def getConcatenation(self, nums: List[int]) -> List[int]:
        ans=[]
        for i in range(2*(len(nums))):
            ind = i%(len(nums))
            ans.append(nums[ind])
        return ans
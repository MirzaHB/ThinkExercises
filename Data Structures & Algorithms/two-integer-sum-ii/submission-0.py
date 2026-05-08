class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        l,r = 0, len(numbers)-1

        while r > l:
            if numbers[r]+numbers[l]>target:
                r-=1
            if numbers[r]+numbers[l]<target:
                l+=1
            if numbers[r]+numbers[l]==target:
                return[l+1,r+1]

class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        repititionCheck = set()
        for n in nums:
            if n not in repititionCheck:
                repititionCheck.add(n)
            else:
                return True
        return False
class Solution:
    def replaceElements(self, arr: List[int]) -> List[int]:
        currMax = -1

        for i in range(len(arr)):
            ind = (i+1) * -1
            newMax = max(currMax, arr[ind])

            arr[ind] = currMax
            currMax = newMax
        return arr
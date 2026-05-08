class Solution:
    def numOfSubarrays(self, arr: List[int], k: int, threshold: int) -> int:
        numarrs=0
        curr=[]

        l=0
        
        for r in range(len(arr)):
            curr.append(arr[r])

            if len(curr)==k:
                if sum(curr)//k>=threshold:
                    numarrs+=1
                curr.remove(arr[l])
                l+=1
        return numarrs

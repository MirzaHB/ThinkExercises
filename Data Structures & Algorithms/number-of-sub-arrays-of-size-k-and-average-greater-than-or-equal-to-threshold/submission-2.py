class Solution:
    def numOfSubarrays(self, arr: List[int], k: int, threshold: int) -> int:
        numarrs=0
        curr=[]
        currsum=0
        l=0
        
        for r in range(len(arr)):
            curr.append(arr[r])
            currsum+=arr[r]
            if r-l+1==k:
                if currsum//k>=threshold:
                    numarrs+=1
                currsum-=arr[l]
                curr.remove(arr[l])
                l+=1
        return numarrs

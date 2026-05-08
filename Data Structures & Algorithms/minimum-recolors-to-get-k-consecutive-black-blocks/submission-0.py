class Solution:
    def minimumRecolors(self, blocks: str, k: int) -> int:
        l=0
        numbs=0
        ans=len(blocks)
        for r in range(len(blocks)):
            if blocks[r]=='B':
                numbs+=1
            if r-l+1==k:
                ans=min(ans,k-numbs)
                if blocks[l]=="B":
                    numbs-=1
                l+=1
        return ans
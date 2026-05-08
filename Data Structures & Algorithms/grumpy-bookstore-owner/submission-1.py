class Solution:
    def maxSatisfied(self, customers: List[int], grumpy: List[int], minutes: int) -> int:
        lind=0
        mostcusts = 0
        currsum=0
        l = 0
        for r in range(len(customers)):
            if grumpy[r]:
                currsum+=customers[r]
            if r-l+1==minutes:
                if currsum>=mostcusts:
                    mostcusts=currsum
                    lind=l
                currsum-=customers[l] if grumpy[l] else 0
                l+=1
        hapcusts=0
        for r in range(len(customers)):
            #r +min -1
            if r>=lind and r<=lind+minutes-1:
                hapcusts+=customers[r]
            elif not grumpy[r]:
                hapcusts+=customers[r]
        return hapcusts
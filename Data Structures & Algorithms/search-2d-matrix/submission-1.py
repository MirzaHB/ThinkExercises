class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        #logm to find correct row
        #logn to find correct column

        top=0
        bot=len(matrix) - 1
        row = 0
        while top<=bot:
            m = (top+bot)//2

            if matrix[m][0]==target:
                return True
            
            if matrix[m][0]>target:
                bot=m-1
            elif matrix[m][0]<target:
                top=m+1
            
        row = bot

        l=0
        r=len(matrix[0])-1

        while l<=r:
            col = (l+r)//2

            if matrix[row][col] == target:
                return True
            
            if matrix[row][col] < target:
                l=col+1
            elif matrix[row][col] > target:
                r=col-1
        return False
            
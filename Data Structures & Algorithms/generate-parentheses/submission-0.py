class Solution:
    def generateParenthesis(self, n: int) -> List[str]:
        opened = 0
        closed = 0
        ans = []
        stack = []


        def bcktrk(opened,closed):
            if opened == n and closed ==n:
                return ans.append(''.join(stack))
            
            if opened == closed:
                stack.append('(')
                bcktrk(opened+1,closed)
                stack.pop()
            
            elif opened > closed:
                if opened < n:
                    stack.append('(')
                    bcktrk(opened+1,closed)
                    stack.pop()
                
                stack.append(')')
                bcktrk(opened,closed+1)
                stack.pop()
        
        bcktrk(opened,closed)
        return ans
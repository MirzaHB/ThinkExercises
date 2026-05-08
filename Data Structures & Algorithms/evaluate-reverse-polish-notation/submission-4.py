class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stck=[]

        for i in range(len(tokens)):
            if tokens[i]=="+":
                res = int(stck.pop(-1))+ int(stck.pop(-1))
                stck.append(res)
            elif tokens[i]=="-":
                res = int(stck.pop(-2))- int(stck.pop(-1))
                stck.append(res)
            elif tokens[i]=="*":
                res = int(stck.pop(-1))*int(stck.pop(-1))
                stck.append(res)
            elif  tokens[i]=="/":
                res = int(stck.pop(-2))/int(stck.pop(-1))
                stck.append(int(res))
            else:
                stck.append(int(tokens[i]))
        return stck[-1]
class MinStack:

    def __init__(self):
        self.stack=[]
        self.minNum=[]
    def push(self, val: int) -> None:
        self.stack.append(val)
        if self.minNum:
            if val<self.minNum[-1]:
                self.minNum.append(val)
            else:
                self.minNum.append(self.minNum[-1])
        else:
            self.minNum.append(val)

    def pop(self) -> None:
        self.stack.pop()
        self.minNum.pop()

    def top(self) -> int:
        return self.stack[-1]

    def getMin(self) -> int:
        return self.minNum[-1]

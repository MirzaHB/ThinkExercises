# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
from collections import deque
class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        result = []
        myQueue = deque()

        if root:
            myQueue.append(root)

        while len(myQueue) > 0:
            temp = []
            for i in range(len(myQueue)):
                curr = myQueue.popleft()
                temp.append(curr.val)
                if curr.left:
                    myQueue.append(curr.left)
                if curr.right:
                    myQueue.append(curr.right)
            result.append(temp)
        return result

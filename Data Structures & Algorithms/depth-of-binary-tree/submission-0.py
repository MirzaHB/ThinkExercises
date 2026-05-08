# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def maxDepth(self, root: Optional[TreeNode]) -> int:
        depth = 0
        q = deque()

        if not root:
            return depth
        
        q.append(root)

        while q:
            depth+=1
            for i in range(len(q)):
                root = q.popleft()

                if root.left:
                    q.append(root.left)
                if root.right:
                    q.append(root.right)
        return depth
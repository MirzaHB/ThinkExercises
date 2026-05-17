/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    int ans = 1;
    public int GoodNodes(TreeNode root) {
        if(root.left != null) preOrder(root.left, root.val);
        if(root.right != null) preOrder(root.right, root.val);
        return ans;
    }
    public void preOrder(TreeNode root, int max){
        bool newBiggest = root.val>=max? true : false;
        if(newBiggest) ans+=1;
        if(root.left!=null)
        {
            if(newBiggest) preOrder(root.left, root.val);else{
                preOrder(root.left, max);
            }

        }
        if(root.right!=null)
        {
            if(newBiggest) preOrder(root.right, root.val);else{
                preOrder(root.right, max);
            }

        }
    }
}

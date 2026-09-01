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
    public bool IsBalanced(TreeNode root) {
        bool isBalanced = true;
        int dfs(TreeNode root){
            int left = 0;
            int right = 0;
            if(root.left!=null) left = dfs(root.left);
            if(root.right !=null) right = dfs(root.right);
            if(Math.Abs(left-right)>1){
                isBalanced = false;
                return Math.Max(left,right)+1;
            }
            else return Math.Max(left,right)+1;
        }
        if(root == null) return true;
        dfs(root);
        return isBalanced;
    }
}

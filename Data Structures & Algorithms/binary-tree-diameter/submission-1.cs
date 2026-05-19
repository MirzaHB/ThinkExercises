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
    public int globalMax = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        dfs(root);
        return globalMax;
    }

    public int dfs(TreeNode root){
        if(root == null) return 0;

        var left = dfs(root.left);
        var right = dfs(root.right);
        var curr = left+right;
        globalMax = curr>globalMax ? curr : globalMax;
        return left>right? left+1 : right+1;
    }
}

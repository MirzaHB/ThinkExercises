/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        TreeNode dfs(TreeNode root){
            if(root == null || root==p || root==q) return root;

            var left = dfs(root.left);
            var right = dfs(root.right);

            if(left != null && right != null){
                return root;
            }
            if(left != null) return left;
            if(right != null) return right;
            return null;
        }
        return dfs(root);
    }
}
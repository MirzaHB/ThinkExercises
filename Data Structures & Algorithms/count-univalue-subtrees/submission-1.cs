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
    public int CountUnivalSubtrees(TreeNode root) {
        int count = 0;

        bool dfs(TreeNode root, int val){
            if(root.left == null && root.right==null){
                count +=1;
                return root.val==val ? true : false;
            }
            var left = root.left!=null ? dfs(root.left, root.val) : true;
            var right = root.right!=null ? dfs(root.right, root.val) : true;
            if(left && right) count +=1;
            return (root.val==val ? true : false) && (left && right);
        }
        if(root==null) return count;
        dfs(root, -1001);
        return count;
    }
}

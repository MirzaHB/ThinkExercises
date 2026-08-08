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
    public double MaximumAverageSubtree(TreeNode root) {
        double ans = 0;
        (long sum,int count) dfs(TreeNode root){
            if(root.left==null && root.right==null) {
                ans = Math.Max(ans, root.val);
                return (root.val,1);
            }

            var left = root.left != null ? dfs(root.left) : (0, 0);
            var right = root.right != null ? dfs(root.right) : (0, 0);
 
            ans = Math.Max(ans,(double)(left.sum+right.sum+root.val)/(left.count+right.count+1));
            return (left.sum+right.sum+root.val, left.count+right.count+1);
        }
        dfs(root);
        return ans;
    }
}

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
        double ans = -1;

        (int, int) dfs(TreeNode root){
            if(root.left == null && root.right == null){
                ans = Math.Max(ans, root.val);
                return (1,root.val);
            }
            var left = 0;
            var right = 0;
            int leftsum = 0;
            int rightsum = 0;
            if(root.left != null) (left, leftsum) = dfs(root.left);
            if(root.right != null) (right, rightsum) = dfs(root.right);
            int totalNodes = 1+left+right;
            var currAvg = (double)(leftsum+rightsum+root.val)/totalNodes;
            ans = Math.Max(ans, currAvg);
            return (totalNodes, leftsum+rightsum+root.val);
        }
        dfs(root);
        return ans;
    }
}

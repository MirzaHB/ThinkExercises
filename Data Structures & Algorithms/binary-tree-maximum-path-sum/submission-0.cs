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
    public int MaxPathSum(TreeNode root) {
        int ans = root.val;

        int dfs(TreeNode curr){
            if(curr==null) return 0;

            var left = dfs(curr.left);
            var right = dfs(curr.right);
            var currAns = Math.Max(left,0) + Math.Max(right,0) + curr.val;
            ans = Math.Max(ans, currAns);
            return Math.Max(Math.Max(left+curr.val, right+curr.val), curr.val);
        }
        dfs(root);
        return ans;
    }
}

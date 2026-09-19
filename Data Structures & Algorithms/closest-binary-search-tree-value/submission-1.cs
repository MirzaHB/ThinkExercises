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
    public int ClosestValue(TreeNode root, double target) {
        double ansDiff = int.MaxValue;
        int ans = 0;

        void dfs(TreeNode curr){
            if(curr==null) return;
            if(ansDiff > Math.Abs((double)curr.val - target)){
                ansDiff = Math.Abs((double)curr.val - target);
                ans = curr.val;
            }
            if(target<curr.val)
                dfs(curr.left);
            else if(target>curr.val)    
                dfs(curr.right);
        }
        dfs(root);
        return ans;
    }
}

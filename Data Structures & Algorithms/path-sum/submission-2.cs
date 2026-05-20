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
    public int goal = 0;
    public bool HasPathSum(TreeNode root, int targetSum) {
        goal = targetSum;
        if(root==null) return false;
        if(root.left==null && root.right== null){
            if(root.val == goal) return true;
            return false;
        }
        return dfs(root.left, root.val) || dfs(root.right, root.val);
    }
    
    public bool dfs(TreeNode curr, int val){
        if(curr == null) return false;
        if(curr.left==null && curr.right== null){
            var currSum = val+curr.val;
            if(currSum == goal) return true;
            return false;
        }
        var left = dfs(curr.left,curr.val+val);
        var right = dfs(curr.right,curr.val+val);
        return left || right;
    }
}
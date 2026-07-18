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
    public int SumNumbers(TreeNode root) {
        int ans = 0;

        void dfs(TreeNode root, int curr){
            
            if(root == null) return;
            if(root.left == null && root.right== null){
                curr= curr*10 + root.val;
                ans+=curr;
                return;
            }
            curr = curr *10 + root.val;
            if(root.left !=null) dfs(root.left, curr);
            if(root.right != null) dfs(root.right, curr);
        }
        dfs(root, 0);
        return ans;
    }
}
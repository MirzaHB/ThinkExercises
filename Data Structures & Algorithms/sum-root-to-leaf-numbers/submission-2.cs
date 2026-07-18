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

            curr= curr*10 + root.val;

            if(root.left == null && root.right== null){
                ans+=curr;
                return;
            }
            dfs(root.left, curr);
            dfs(root.right, curr);
        }
        dfs(root, 0);
        return ans;
    }
}
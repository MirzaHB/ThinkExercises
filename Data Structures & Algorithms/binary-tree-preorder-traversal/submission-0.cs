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
    List<int> ans = new();
    public List<int> PreorderTraversal(TreeNode root) {
        preOrder(root);
        return ans;
    }

    public void preOrder(TreeNode root){
        if(root == null) return;

        ans.Add(root.val);
        preOrder(root.left);
        preOrder(root.right);
    }
}
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
    List<int> answer = new();
    public List<int> InorderTraversal(TreeNode root) {
        inorder(root);
        return answer;
    }

    public void inorder(TreeNode root){
        if(root == null) return;

        inorder(root.left);
        answer.Add(root.val);
        inorder(root.right);
    }
}
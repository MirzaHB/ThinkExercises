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
    public List<int> PostorderTraversal(TreeNode root) {
        var ans = new List<int>();
        void POT(TreeNode curr){
            if(curr.left==null && curr.right==null) {ans.Add(curr.val); return;}
            if(curr.left !=null) POT(curr.left);
            if(curr.right!=null) POT(curr.right);
            ans.Add(curr.val);
        }
        if(root==null) return [];
        POT(root);
        return ans;
    }
}
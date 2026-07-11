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
    public int LongestConsecutive(TreeNode root) {
        int ans = 1;
        if(root == null) return ans;
        Queue<(TreeNode,int, int)> q = new();
        q.Enqueue((root,root.val,1));

        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var (node, pval, seqlen) = q.Dequeue();
                if(node.val == pval+1) {
                    ans = Math.Max(ans, seqlen+1);
                    if(node.left != null) q.Enqueue((node.left, node.val, seqlen+1));
                    if(node.right != null)q.Enqueue((node.right, node.val, seqlen+1));
                }else{
                    if(node.left != null) q.Enqueue((node.left, node.val, 1));
                    if(node.right != null)q.Enqueue((node.right, node.val, 1));                    
                }
            }
        }
        return ans;
    }
}

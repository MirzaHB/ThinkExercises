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
        var q = new Queue<(TreeNode,int,int)>();
        if(root!=null){
            if(root.left!=null) q.Enqueue((root.left, root.val, 1));
            if(root.right!=null) q.Enqueue((root.right,root.val,1));
        }
        
        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var (curr, pval, len) = q.Dequeue();
                var nlen = curr.val==pval+1 ? len+1 : 1;
                ans = Math.Max(ans, nlen);
                if(curr.left!=null) q.Enqueue((curr.left, curr.val, nlen));
                if(curr.right!=null)q.Enqueue((curr.right, curr.val, nlen));
            }
        }
        return ans;
    }
}

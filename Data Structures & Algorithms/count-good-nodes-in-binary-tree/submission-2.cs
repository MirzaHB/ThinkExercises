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
    public int GoodNodes(TreeNode root) {
        int ans =0;
        Queue<(int,TreeNode)> q = new();

        if(root == null) return ans;
        q.Enqueue((int.MinValue, root));

        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var (num, node) = q.Dequeue();
                if(node.val>=num) ans+=1;

                if(node.left!=null) q.Enqueue((Math.Max(num,node.val), node.left));
                if(node.right!=null)q.Enqueue((Math.Max(num,node.val), node.right));
            }
        }
        return ans;
    }
}

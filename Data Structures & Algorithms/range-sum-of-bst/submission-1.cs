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
    public int RangeSumBST(TreeNode root, int low, int high) {
        int ans = 0;
        Queue<TreeNode> q = new();
        if(root != null) q.Enqueue(root);

        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var curr = q.Dequeue();
                if(curr.val>=low && curr.val<=high) ans+=curr.val;
                if(curr.left!=null && curr.val>=low) q.Enqueue(curr.left);
                if(curr.right!=null && curr.val<=high) q.Enqueue(curr.right);
            }
        }
        return ans;
    }
}
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
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        Queue<TreeNode> q = new();
        int ans = 0;

        q.Enqueue(root);
        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var node = q.Dequeue();
                if(node.left != null) q.Enqueue(node.left);
                if(node.right !=null) q.Enqueue(node.right);
            }
            ans++;
        }
        return ans;
    }
}

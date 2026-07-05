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
    public List<int> RightSideView(TreeNode root) {
        List<int> ans = new();
        Queue<TreeNode> q = new();

        if(root==null) return ans;
        q.Enqueue(root);

        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var node = q.Dequeue();
                if(i==qlen-1) ans.Add(node.val);

                if(node.left != null) q.Enqueue(node.left);
                if(node.right !=null) q.Enqueue(node.right);
            }
        }
        return ans;
    }
}

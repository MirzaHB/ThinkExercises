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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> ans = new();
        Queue<TreeNode> q = new();

        if(root == null) return ans;
        q.Enqueue(root);

        while(q.Any()){
            var qlen = q.Count;
            List<int> curr = new();
            for(int i=0; i<qlen; i++){
                var node = q.Dequeue();
                if(node.left != null) q.Enqueue(node.left);
                if(node.right!= null) q.Enqueue(node.right);
                curr.Add(node.val);
            }
            ans.Add(curr);
        }
        return ans;
    }
}

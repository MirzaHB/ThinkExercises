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
        if(root == null) return [];
        Queue<TreeNode> q = new();
        q.Enqueue(root);

        List<List<int>> ans = new();

        while(q.Count>0){
            var nodes = q.Count;
            List<int> lvl = new();
            for(int i = 0; i < nodes; i++){
                var curr = q.Dequeue();
                lvl.Add(curr.val);
                if(curr.left != null) q.Enqueue(curr.left);
                if(curr.right != null) q.Enqueue(curr.right);
            }
            ans.Add(lvl);
        }
        return ans;
    }
}

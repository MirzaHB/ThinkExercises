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
        if(root == null) return [];
        List<int> ans = new();
        Queue<TreeNode> q = new();
        q.Enqueue(root);

        while(q.Count>0){
            var numNodes = q.Count;
            for(int i=0; i<numNodes; i++){
                var curr = q.Dequeue();
                if(curr.left != null) q.Enqueue(curr.left);
                if(curr.right != null) q.Enqueue(curr.right);
                if(i==numNodes-1){ans.Add(curr.val);}
            }
        }
        return ans;
    }
}

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
    public int KthSmallest(TreeNode root, int k) {
        var arr = Bfs(root);
        arr.Sort();
        return arr[k-1];
    }
    public List<int> Bfs(TreeNode root){
        if(root == null) return [];
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        List<int> arr = new();
        while(q.Count>0){
            var numNodes = q.Count;
            for(int i=0;i<numNodes; i++){
                var curr = q.Dequeue();
                arr.Add(curr.val);
                if(curr.left!=null) q.Enqueue(curr.left);
                if(curr.right!=null) q.Enqueue(curr.right);
            }
        }
        return arr;
    }
}

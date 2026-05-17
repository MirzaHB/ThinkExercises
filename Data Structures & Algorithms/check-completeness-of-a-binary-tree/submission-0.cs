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
    public bool IsCompleteTree(TreeNode root) {
      // dont add to q if flag is triggered
      bool flag = false;
      Queue<TreeNode> q = new();
      q.Enqueue(root);

      while(q.Count>0){
        var numNodes = q.Count;
        for(int i=0; i<numNodes; i++){
            var curr = q.Dequeue();
            if((curr.left != null || curr.right!=null) && flag) return false;
            if(curr.left != null && !flag) q.Enqueue(curr.left); else flag = true;
            if(curr.right !=null && flag) return false;
            if(curr.right != null && !flag) q.Enqueue(curr.right); else flag = true;
        }
      }
      return true;

    }
}
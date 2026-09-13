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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        
        while(q.Any()){
            var qlen = q.Count;
            for(int i=0;i<qlen;i++){
                var curr = q.Dequeue();
                if(curr.val == subRoot.val){
                    var found = IsSameTree(curr, subRoot);
                    if(found) return true;
                }
                if(curr.left!=null) q.Enqueue(curr.left);
                if(curr.right!=null) q.Enqueue(curr.right);
            }
        }
        return false;

        bool IsSameTree(TreeNode r1, TreeNode r2){
            if(r1==null && r2==null) return true;
            if(r1==null || r2==null) return false;
            if(r1.val != r2.val) return false;

            return IsSameTree(r1.left, r2.left) && IsSameTree(r1.right, r2.right);
        }
    }
}

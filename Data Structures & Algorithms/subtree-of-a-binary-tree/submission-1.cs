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
        bool find(TreeNode r1){
            if(r1==null) return false;
            if(r1.val == subRoot.val){
                var found = IsSameTree(r1, subRoot);
                if(found) return true;
            }
            return find(r1.left) || find(r1.right);
        }

        bool IsSameTree(TreeNode r1, TreeNode r2){
            if(r1==null && r2==null) return true;
            if(r1==null || r2==null) return false;
            if(r1.val != r2.val) return false;

            return IsSameTree(r1.left, r2.left) && IsSameTree(r1.right, r2.right);
        }
        return find(root);
    }
}

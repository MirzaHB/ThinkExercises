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
    public List<List<int>> ZigzagLevelOrder(TreeNode root) {
        if(root == null) return [];
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        List<List<int>> ans = new();
        bool lvl = true;

        while(q.Count>0){
            var numNodes = q.Count;
            List<int> currLvl = new();
            List<int> tmpStore = new();
            for(int i=0; i<numNodes; i++){
                var curr = q.Dequeue();                
                if(curr.left != null) q.Enqueue(curr.left);
                if(curr.right != null) q.Enqueue(curr.right);
                tmpStore.Add(curr.val);
            }
            for(int i=0; i<tmpStore.Count;i++){
                if(lvl){
                    currLvl.Add(tmpStore[i]);
                }else{currLvl.Add(tmpStore[tmpStore.Count-1-i]);}
            }
            lvl = !lvl;
            ans.Add(currLvl);
        }
        return ans;
    }
}
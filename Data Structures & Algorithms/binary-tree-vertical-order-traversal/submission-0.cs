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
    public List<List<int>> VerticalOrder(TreeNode root) {
        List<List<int>> ans = new();
        Dictionary<int,List<int>> dict = new();
        PriorityQueue<int,int> indexes = new();
        Queue<(int,TreeNode)> q = new();
        if(root==null) return ans;
        q.Enqueue((0,root));

        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var (index, node) = q.Dequeue();
                if(!dict.ContainsKey(index)){ 
                    dict[index] = new List<int>();
                    indexes.Enqueue(index,index);
                }
                dict[index].Add(node.val);
                if(node.left!=null) q.Enqueue((index-1,node.left));

                if(node.right!=null) q.Enqueue((index+1,node.right));
            }
        }
        var numInd = indexes.Count;
        for(int i=0;i<numInd;i++){
            List<int> curr = new();
            int ind = indexes.Dequeue();
            foreach(var num in dict[ind]){
                curr.Add(num);
            }
            ans.Add(curr);
        }
        return ans;
    }
}
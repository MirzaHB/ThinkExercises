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
        var ans = new List<List<int>>();
        var dict = new Dictionary<int,List<int>>();
        var q = new Queue<(TreeNode,int)>();
        int low = 0;
        int high = 0;
        if(root==null) return [];
        if(root!=null) q.Enqueue((root,0));

        while(q.Any()){
            var qlen = q.Count;
            for(int i=0;i<qlen;i++){
                var (curr,num) = q.Dequeue();
                if(!dict.ContainsKey(num)){
                    dict[num] = new List<int>();
                    low = Math.Min(low,num);
                    high = Math.Max(high,num);
                }
                dict[num].Add(curr.val);
                if(curr.left!=null) q.Enqueue((curr.left,num-1));
                if(curr.right!=null) q.Enqueue((curr.right,num+1));
            }
        }
        for(int i=low; i<=high; i++)
            ans.Add(dict[i].ToList());
        return ans;
    }
}
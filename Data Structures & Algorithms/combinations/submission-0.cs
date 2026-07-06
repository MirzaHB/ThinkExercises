public class Solution {
    public List<List<int>> Combine(int n, int k) {
        List<List<int>> ans = new();
        helper(n,k,1,0,[],ans);
        return ans;
    }

    public void helper(int n, int k, int i, int count, List<int> curr, List<List<int>> ans){
        if(count == k){
            ans.Add(curr.ToList());
            return;    
        }
        if(i>n) return;
        curr.Add(i);
        helper(n,k,i+1,count+1,curr,ans);
        curr.RemoveAt(curr.Count-1);
        helper(n,k,i+1,count,curr,ans);
    }
}
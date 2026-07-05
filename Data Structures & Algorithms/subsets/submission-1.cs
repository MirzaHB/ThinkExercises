public class Solution {
    public List<List<int>> ans = new();
    public List<List<int>> Subsets(int[] nums) {
        dfs(nums, [], 0);
        return ans;
    }
    public void dfs(int[] nums, List<int> curr, int i){
        if(i >= nums.Length){
            ans.Add(curr.ToList());
            return;
        }
        curr.Add(nums[i]);
        dfs(nums, curr, i+1);
        curr.RemoveAt(curr.Count-1);
        dfs(nums, curr, i+1);
    }
}

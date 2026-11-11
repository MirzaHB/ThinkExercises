public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> ans = new();

        void dfs(List<int> curr, int sum, int i){
            if(sum==target){
                ans.Add(curr.ToList());
                return;
            }
            if(i==nums.Length || sum>target) return;
            curr.Add(nums[i]);
            dfs(curr, sum+nums[i], i);
            curr.RemoveAt(curr.Count-1);
            dfs(curr, sum, i+1);
        }
        dfs([],0,0);
        return ans;
    }
}

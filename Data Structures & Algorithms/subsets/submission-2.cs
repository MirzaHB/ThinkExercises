public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> ans = new();

        void dfs(List<int> curr, int index){
            if(index==nums.Length){
                ans.Add(curr.ToList());
                return;
            }

            curr.Add(nums[index]);
            dfs(curr, index+1);
            curr.RemoveAt(curr.Count-1);
            dfs(curr, index+1);
        }
        dfs(new List<int>(), 0);
        return ans;
    }
}

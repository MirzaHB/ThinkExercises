public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        List<List<int>> ans = new();
        Array.Sort(nums);

        void dfs(List<int> curr, int i){
            if(i==nums.Length){
                ans.Add(curr.ToList());
                return;
            }
            
            curr.Add(nums[i]);
            dfs(curr,i+1);

            while(i+1<nums.Length && nums[i] == nums[i+1]) i++;
            curr.RemoveAt(curr.Count-1);
            dfs(curr,i+1);
        }
        dfs([],0);
        return ans;
    }
}

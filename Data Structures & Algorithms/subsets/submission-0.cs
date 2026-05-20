public class Solution {
    List<List<int>> ans = new();
    public List<List<int>> Subsets(int[] nums) {
        backtrack(nums, [], 0);
        return ans;
    }
    public void backtrack(int[] nums, List<int> curr, int i){
        if(i>=nums.Length) {ans.Add(new List<int>(curr)); return;}

        var newCurr = new List<int>(curr);
        newCurr.Add(nums[i]);
        backtrack(nums, newCurr, i+1);
        backtrack(nums, curr, i+1);
    }
}

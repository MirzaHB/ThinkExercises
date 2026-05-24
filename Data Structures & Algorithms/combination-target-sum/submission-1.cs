public class Solution {
    public List<List<int>> ans = new();
    public int[] arr;
    public List<List<int>> CombinationSum(int[] nums, int target) {
        arr = nums;
        backTrack(new List<int>(), 0,target);
        return ans;
    }

    public void backTrack(List<int> nums, int i, int target){
        if(target==0){
            ans.Add(nums.ToList());
            return;
        }

        if(i>arr.Length-1 || target<0) return;

        backTrack([..nums, arr[i]], i, target-arr[i]);
        backTrack(nums.ToList(), i+1, target);
    }
}

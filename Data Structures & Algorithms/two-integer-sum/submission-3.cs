public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new();

        for(int i=0; i<nums.Length; i++){
            dict[nums[i]] = i;
        }

        for(int r=0; r<nums.Length; r++){
            if(dict.ContainsKey(target-nums[r]) && dict[target-nums[r]]!=r){
                return [Math.Min(dict[target-nums[r]], r), Math.Max(dict[target-nums[r]], r)];
            }
        }
        return [];
    }
}

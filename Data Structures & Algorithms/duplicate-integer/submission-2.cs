public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new();
        for(int i=0;i<nums.Length;i++){
            if(set.Contains(nums[i])) return true;
            set.Add(nums[i]);
        }
        return false;
    }
}
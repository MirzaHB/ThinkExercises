public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new();
        for(int i=0; i< nums.Length; i++){
            var targ = target-nums[i];
            if(map.ContainsKey(targ)) return [map[targ], i];
            map[nums[i]] = i;
        }
        return [0,0];
    }
}

public class Solution {
    public long MaximumSumScore(int[] nums) {
        var preFixes = new long[nums.Length];
        long total = 0;
        for(int i=0; i<nums.Length; i++){
            total +=nums[i];
            preFixes[i]=(total);
        }

        var ans = long.MinValue;

        for(int i=0; i<nums.Length; i++){
            var right = preFixes[nums.Length-1] - preFixes[i] + nums[i];
            var curr = Math.Max(preFixes[i], right);
            ans = Math.Max(ans, curr);
        }
        return ans;
    }
}

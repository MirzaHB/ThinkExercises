public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int delen = 1;
        int inlen = 1;
        int ans = 1;

        for(int i=0; i<nums.Length; i++){
            if(i>0 && nums[i]<nums[i-1]) delen++;
            else delen = 1;

            if(i>0 && nums[i]>nums[i-1]) inlen++;
            else inlen=1;

            ans = Math.Max(ans, Math.Max(inlen, delen));
        }
        return ans;
    }
}
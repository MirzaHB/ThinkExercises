public class Solution {
    public int MaxFrequency(int[] nums, int k) {
        var ans = 0;
        int l = 0;
        var sum = 0;
        Array.Sort(nums);

        for(int r=0; r<nums.Length; r++){
            sum+=nums[r];
            while(nums[r]*(r-l+1) > sum+k){
                sum -= nums[l];
                l+=1;
            }

            ans = Math.Max(ans, r-l+1);
        }
        return ans;
    }
}
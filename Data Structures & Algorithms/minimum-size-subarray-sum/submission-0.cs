public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int ans = int.MaxValue;
        int l = 0;
        int curr = 0;
    
        for(int r=0; r<nums.Length; r++){
            curr+=nums[r];
            while(curr>=target){
                ans = Math.Min(ans, r-l+1);
                curr-=nums[l];
                l++;
            }
        }
        return ans!=int.MaxValue ? ans : 0;
    }
}
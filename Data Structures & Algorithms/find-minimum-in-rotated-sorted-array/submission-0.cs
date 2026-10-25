public class Solution {
    public int FindMin(int[] nums) {
        int l = 0;
        int r = nums.Length-1;
        int ans = int.MaxValue;
        while(l<=r){
            if(nums[l]<nums[r]){
                ans = Math.Min(nums[l], ans);
                break;
            }

            int mid  = l + (r-l)/2;
            ans = Math.Min(ans, nums[mid]);
            if(nums[mid]>=nums[l]){
                l = mid+1;
            }else{ r = mid-1;}
        }
        return ans;
    }
}

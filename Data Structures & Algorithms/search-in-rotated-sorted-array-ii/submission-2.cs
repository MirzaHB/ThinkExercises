public class Solution {
    public bool Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length -1;

        while(l<=r){
            int m = l+(r-l)/2;
            if(nums[m]==target) return true;
            if(nums[l] == nums[r] && nums[m]==nums[r]){
                l++;
                r--;
                continue;
            }
            if(nums[m]==nums[l]) {l++;continue;}
            if(nums[m]==nums[r]) {r--;continue;}
            if(nums[m]>nums[l]){
                if(target<nums[m] && target>=nums[l]) r=m-1;
                else l=m+1;
            }else{
                if(target>nums[m] && target<=nums[r]) l = m+1;
                else r=m-1;
            }
        }
        return false;
    }
}
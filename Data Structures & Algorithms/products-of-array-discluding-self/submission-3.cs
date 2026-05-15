public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var allbut0 = 1;
        var contains0 = false;
        var multiple0s = false;
        foreach(var i in nums){
            if(i!=0)
                allbut0=allbut0*i;
            else{
                if(contains0) multiple0s = true;
                contains0 = true;
            }
        }

        int[] ans = new int[nums.Length];

        for(var i = 0; i<nums.Length; i++){
            if(!multiple0s && contains0 && nums[i]==0)
                ans[i] = allbut0;
            else if (multiple0s) ans[i] = 0;
            else if(!multiple0s && contains0 && nums[i]!=0) ans[i] = 0;
            else ans[i] = allbut0/nums[i];
        }
        return ans;
    }
}

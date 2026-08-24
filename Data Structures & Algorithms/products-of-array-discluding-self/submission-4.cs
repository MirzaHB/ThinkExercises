public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if(nums.Length == 2)
            return [nums[1],nums[0]];

        int[] pre = new int[nums.Length];
        int[] post = new int[nums.Length];
        var preTotal = 1;
        var postTotal = 1;

        for(int i=0; i<nums.Length; i++){
            preTotal = nums[i]*preTotal;
            pre[i] = preTotal;
        }
        for(int i=nums.Length-1; i>-1; i--){
            postTotal = nums[i]*postTotal;
            post[i] = postTotal;
        }
        int[] ans = new int[nums.Length];
        for(int i=0;i<nums.Length; i++){
            if(i==0){ 
                ans[i] = post[i+1];
                continue;
            }
            if(i==nums.Length-1){
                ans[i] = pre[nums.Length-2];
                continue;
            }
            ans[i] = pre[i-1] * post[i+1];
        }
        return ans;
    }
}

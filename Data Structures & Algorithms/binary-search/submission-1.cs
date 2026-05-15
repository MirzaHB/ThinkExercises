public class Solution {
    public int Search(int[] nums, int target) {
        var r = nums.Length-1;
        var l = 0;

        while(l<=r){
            var m = (l+r)/2;
            if(nums[m]>target) r = m-1;
            else if(nums[m]<target) l=m+1;
            else return m;
        }
        return -1;
    }
}

public class Solution {
    public int PivotIndex(int[] nums) {
        var pres = new int[nums.Length];
        var post = new int[nums.Length];
        var leftTotal = 0;
        var rightTotal = 0;

        for(int i=0; i<nums.Length; i++){
            leftTotal += nums[i];
            pres[i]=leftTotal;        
        }

        for(int i=nums.Length-1; i>-1; i--){
            rightTotal +=nums[i];
            post[i]=rightTotal;
        }
        var l=0;
        var r=nums.Length;
        for(int i=0; i<nums.Length; i++){
            if(pres[i]-nums[i] == post[i]-nums[i]) return i;
        }
        return -1;
    }
}
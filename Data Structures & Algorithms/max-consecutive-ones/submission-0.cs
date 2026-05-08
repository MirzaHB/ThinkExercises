public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int answer = 0;
        int curr = 0;

        foreach(var num in nums){
            if(num == 1) {
                curr+=1;
                if(curr>=answer) answer = curr;
            }
            else{
                curr = 0;
            }
        }
        return answer;
    }
}
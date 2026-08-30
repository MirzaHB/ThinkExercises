public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        HashSet<int> set = new();
        int ans = 1;

        foreach(int n in nums) set.Add(n);

        foreach(int n in nums){
            var start = n;
            int curr = 1;
            
            if(set.Contains(n-1)) continue;

            while(set.Contains(start+1)){
                curr++;
                ans = Math.Max(curr, ans);
                start++;
            }
        }
        return ans;
    }
}

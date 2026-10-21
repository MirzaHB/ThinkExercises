public class Solution {
    public bool isConsecutive(int[] nums) {
        if(nums.Length==1) return true;
        var set = new HashSet<int>();
        int min = int.MaxValue;
        foreach(var n in nums){
            min = Math.Min(min, n);
            set.Add(n);
        }
        if(set.Count!=nums.Length) return false;
        int i =0;
        int curr = min;
        while(i<set.Count-1){
            if(set.Contains(curr+1)) curr = curr+1;
            else return false;
            i++;
        }
        return true;
    }
}

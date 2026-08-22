public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new();
        foreach(int n in nums){
            if(set.Contains(n)) return true;
            set.Add(n);
        }
        return false;
    }
}
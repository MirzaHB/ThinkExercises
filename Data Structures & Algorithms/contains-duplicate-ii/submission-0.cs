public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> dupe = new();
        int l=0;

        for(int r=0; r<nums.Length; r++){
            if(r-l>k){
                dupe.Remove(nums[l]);
                l+=1;
            }
            if(dupe.Contains(nums[r])) return true;
            dupe.Add(nums[r]);
        }
        return false;
    }
}
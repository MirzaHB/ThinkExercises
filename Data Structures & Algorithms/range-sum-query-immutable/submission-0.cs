public class NumArray {
    public List<int> prefixes = new();
    public NumArray(int[] nums) {
        int total = 0;
        for(int i=0;i<nums.Length;i++){
            total+=nums[i];
            prefixes.Add(total);
        } 
    }
    
    public int SumRange(int left, int right) {
        return left>0 ? prefixes[right] - prefixes[left-1] : prefixes[right];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
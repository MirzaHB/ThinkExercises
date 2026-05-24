public class Solution {
    public List<List<int>> Permute(int[] nums) {
        return helper(nums,0);
    }

    public List<List<int>> helper(int[] nums, int index){
        if(index == nums.Length) return new List<List<int>> { new List<int>() };

        var prefixes = helper(nums, index+1);
        List<List<int>> curr = new();
        foreach(var pres in prefixes){
            for(int i=0; i<=pres.Count;i++){
                var prescpy = new List<int>(pres);
                prescpy.Insert(i, nums[index]);
                curr.Add(prescpy);
            }
        }
        return curr;
    }
}

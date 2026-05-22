public class Solution {
    int[] arg;
    int targ;
    List<List<int>> ans = new();
    public List<List<int>> CombinationSum(int[] nums, int target) {
        arg = nums;
        targ = target;
        bckTrk([], 0, target);
        return ans;
    }
    public void bckTrk(int[] curr, int i, int leftover){
        if(leftover==0){
            ans.Add(curr.ToList());
            return;
        }
        if(leftover<0 || i>=arg.Length) return;
        
        bckTrk(curr.Append(arg[i]).ToArray(), i,leftover-arg[i]);
        bckTrk(curr.ToArray(), i+1, leftover);
    }
}

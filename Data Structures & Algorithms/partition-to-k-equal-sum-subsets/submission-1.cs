public class Solution {
    public bool CanPartitionKSubsets(int[] nums, int k) {
        int total = 0;
        foreach(int n in nums) total+=n;
        if(total%k!=0) return false;
        int target = total/k;
        Array.Sort(nums, (a,b) => b.CompareTo(a));
        bool dfs(List<int> subsets, int index){
            if(index == nums.Length){
                foreach(int subset in subsets)
                    if(subset != target) return false;
                return true;
            }
            if(nums[index]> target) return false;

            for(int i=0; i<k; i++){
                if(subsets[i]+nums[index]<=target){
                    subsets[i]+=nums[index];
                    if(dfs(subsets, index+1)) return true;
                    subsets[i]-=nums[index];
                }
            }
            return false;
        }
        return dfs(new List<int>(new int[k]), 0);
    }
}
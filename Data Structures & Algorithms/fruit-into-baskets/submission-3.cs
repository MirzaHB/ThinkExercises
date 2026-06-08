public class Solution {
    public int TotalFruit(int[] nums) {
        Dictionary<int, int> uFruits = new();
        var global = 0;
        int l=0;
        var ans = 0;

        for(int r=0; r<nums.Length; r++){
            if (uFruits.TryGetValue(nums[r], out int currentCount)){
                uFruits[nums[r]] = currentCount + 1;
            }else uFruits[nums[r]] = 1; 

            if(uFruits.Count>2){
                var x = nums[l];
                uFruits.TryGetValue(nums[l], out var count);
                for(int i=l; uFruits.Count>2 && count>0; i++){
                    if(nums[i] == x){
                        count-=1;
                    }
                    uFruits[nums[l]]--;
                    if (uFruits[nums[l]] == 0)
                        uFruits.Remove(nums[l]);
                    l+=1;
                }
            }
            ans = Math.Max(ans, r-l+1);
        }
        return ans;
    }
}
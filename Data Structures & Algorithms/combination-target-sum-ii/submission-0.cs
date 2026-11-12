public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<List<int>> ans = new();
        Array.Sort(candidates);

        void backTrack(List<int> curr, int sum, int i){
            if(sum==target){
                ans.Add(curr.ToList());
                return;
            }
            if(i>=candidates.Length || sum>target) return;

            curr.Add(candidates[i]);
            backTrack(curr, sum+candidates[i], i+1);
            curr.RemoveAt(curr.Count-1);
            int nextI=i;
            while(candidates[i]==candidates[nextI]){
                nextI++;
                if(nextI>=candidates.Length) return;
            }
            backTrack(curr, sum, nextI);
        }
        backTrack([],0,0);
        return ans;
    }
}

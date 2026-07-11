public class Solution {
    public bool Makesquare(int[] matchsticks) {
        if(matchsticks.Length<4) return false;
        var total = 0;
        foreach(int n in matchsticks) total+=n;
        if(total%4!=0) return false;
        int target = total/4;
        Array.Sort(matchsticks, (a, b) => b.CompareTo(a));
        bool dfs(List<int> sides, int index){
            if(index == matchsticks.Length)
                return sides[0]==sides[1] && sides[1]==sides[2] && sides[2]==sides[3];
            
            if(matchsticks[index]>target) return false;

            for(int i=0; i<4; i++){
                if (sides[i] + matchsticks[index] <= target) {
                    sides[i] += matchsticks[index];
                    if (dfs(sides, index + 1)) return true;
                    sides[i] -= matchsticks[index];
                }

                if (sides[i] == 0) break;
            }
            return false;
        }
        return dfs(new List<int>{0,0,0,0}, 0);
    }
}
public class Solution {
    public bool Makesquare(int[] matchsticks) {
        var total = matchsticks.Sum();
        if(total % 4 != 0 ) return false;
        var maxLen = total/4;
        var sides = new List<int>{0,0,0,0};

        Array.Sort(matchsticks);
        Array.Reverse(matchsticks);

        bool backTrack(int i, List<int> curr){
            if(i==matchsticks.Length) 
                return curr[0]==curr[1] && curr[1]==curr[2] && curr[2]==curr[3];
            
            for(int k=0; k<4; k++){
                if(curr[k] + matchsticks[i] > maxLen || (k>0 && curr[k]==curr[k-1])) continue;
                curr[k] += matchsticks[i];
                if(backTrack(i+1, curr)) return true;
                curr[k] -= matchsticks[i];
            }
            return false;
        }
        return backTrack(0, sides);
    }
}
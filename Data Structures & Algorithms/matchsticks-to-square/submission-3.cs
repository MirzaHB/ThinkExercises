public class Solution {
    public bool Makesquare(int[] matchsticks) {
        int total = 0;
        foreach(int n in matchsticks) total+=n;
        if(total%4 != 0) return false;
        int sideLen = total/4;

        int[] sorted = matchsticks.OrderByDescending(x=>x).ToArray();
        int[] arr = new int[4];

        bool helper(int[] curr, int i){
            if(i==matchsticks.Length)
                return curr[0]==curr[1] && curr[1]==curr[2] && curr[2]==curr[3];
            
            for(int k=0; k<4; k++){
                if(curr[k]+sorted[i]>sideLen) continue;
                curr[k] += sorted[i];
                if(helper(curr,i+1)) return true;
                curr[k] -= sorted[i];
            }
            return false;
        }
        return helper(arr, 0);
    }
}
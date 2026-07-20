public class Solution {
    public bool Makesquare(int[] matchsticks) {
        int total = 0;
        foreach(int n in matchsticks) total+=n;
        if(total%4 != 0) return false;
        int target = total/4;
        Array.Sort(matchsticks,(a,b) => b.CompareTo(a));
        var sides = new List<int>{0,0,0,0};

        bool dfs(int index){
            if(index==matchsticks.Length)
                return (sides[0]==sides[1]) && (sides[1]==sides[2]) && (sides[2]==sides[3]);
            
            if(matchsticks[index]>target) return false;

            for(int i=0; i<4; i++){
                if(sides[i]+matchsticks[index]<=target){
                    if(i>0 && sides[i]==sides[i-1]) continue;
                    sides[i]+=matchsticks[index];
                    if(dfs(index+1)) return true;
                    sides[i]-=matchsticks[index];
                }
            }
            return false;
        }
        return dfs(0);
    }
}
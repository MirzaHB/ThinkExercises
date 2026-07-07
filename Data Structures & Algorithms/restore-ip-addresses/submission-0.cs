public class Solution {
    public List<string> RestoreIpAddresses(string s) {
        List<string> ans = new();
        if(s.Length>12) return ans;

        void backtrack(string curr, int dots, int i){
            if(dots==4 && i==s.Length){
                ans.Add(curr.Substring(0,curr.Length-1));
                return;
            }
            if(dots>4) return;

            for(int j=i; j<Math.Min(i+3,s.Length);j++){
                if(j!=i && s[i]=='0') continue;
                string numstr = s.Substring(i,j-i+1);
                if(int.Parse(numstr)<256){
                    backtrack(curr+numstr+'.', dots+1, j+1);
                }
            }
        }
        backtrack("", 0, 0);
        return ans;
    }
}
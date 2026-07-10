public class Solution {
    public List<string> RestoreIpAddresses(string s) {
        List<string> ans = new();
        if(s.Length>12) return ans;

        void helper(string curr, int i, int dots){
            if(dots==4 && i==s.Length){
                ans.Add(curr.Remove(curr.Length-1));
                return;
            }
            for(int j=i; j<Math.Min(i+3,s.Length);j++){
                if(s.Substring(i,j-i+1) == "0"){
                    helper(curr+s.Substring(i,j-i+1)+'.', j+1, dots+1);
                    break;
                }
                var num = s.Substring(i,j-i+1);
                if(int.Parse(num)>255) continue;            
                helper(curr + num +'.', j+1, dots+1);
            }
        }
        helper("",0,0);
        return ans;
    }
}
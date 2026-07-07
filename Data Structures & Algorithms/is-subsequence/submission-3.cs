public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length > t.Length) return false;
        if(s.Length == 0) return true;
        int sIndex = 0;
        for(int i=0; i<t.Length; i++){
            if(s[sIndex] == t[i]){
                sIndex+=1;
                if(sIndex == s.Length) return true;
            }
        }
        return false;
    }
}
public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> sD = new();
        Dictionary<char, int> tD = new();

        if(s.Length != t.Length) return false;

        for(int i=0; i<s.Length; i++){
            sD.TryGetValue(s[i], out int sVal);
            sD[s[i]] = sVal + 1;
            
            tD.TryGetValue(t[i], out int tVal);
            tD[t[i]] = tVal + 1;
        }
        if(sD.Count != tD.Count) return false;
        for(int i=0; i<s.Length;i++){
            if(!tD.ContainsKey(s[i])) return false;
            if(tD[s[i]] != sD[s[i]]) return false;
        }
        return true;
    }
}

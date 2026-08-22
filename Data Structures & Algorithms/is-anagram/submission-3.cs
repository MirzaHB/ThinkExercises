public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> sdict = new();
        Dictionary<char, int> tdict = new();

        for(int i=0; i<s.Length;i++){
            if(!sdict.ContainsKey(s[i])) sdict[s[i]]=0;
            sdict[s[i]]+=1;
            if(!tdict.ContainsKey(t[i])) tdict[t[i]] = 0;
            tdict[t[i]]+=1;
        }
        if(sdict.Count != tdict.Count) return false;
        foreach(char c in s){
            if(!tdict.ContainsKey(c)) return false;
            if(tdict[c]!=sdict[c]) return false;
        }
        return true;
    }
}

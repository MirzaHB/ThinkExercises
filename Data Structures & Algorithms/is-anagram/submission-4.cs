public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] sCount = new int[26];
        int[] tCount = new int[26];
        foreach(char c in s) sCount[c-'a']++;
        foreach(char c in t) tCount[c-'a']++;
        var skey = string.Join(",",sCount);
        var tkey = string.Join(",",tCount);
        return string.Equals(skey,tkey, StringComparison.Ordinal) ? true : false;
    }
}

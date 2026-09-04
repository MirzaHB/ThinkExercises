public class Solution {
    public string MergeAlternately(string word1, string word2) {
        bool flag = true;
        string ans = "";
        int len = Math.Max(word1.Length, word2.Length);
        int l1 = 0;
        int l2 = 0;
        while(l1<word1.Length || l2<word2.Length){
            if(flag) {ans+=word1[l1]; l1+=1;}
            else {ans+=word2[l2]; l2+=1;}
            if(l1>=word1.Length) flag = false;
            else if(l2>=word2.Length) flag = true;
            else flag = !flag;
        }
        return ans;
    }
}
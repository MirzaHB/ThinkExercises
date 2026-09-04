public class Solution {
    public bool ValidPalindrome(string s) {
        int l=0;
        int r = s.Length-1;

        while(l<r){
            if(s[l]!=s[r]){
                return validPali2(s.Substring(l+1, r-l)) || validPali2(s.Substring(l,r-l));
            }
            l++;
            r--;
        }
        return true;

        bool validPali2(string s){
            int l=0;
            int r = s.Length-1;

            while(l<r){
                if(s[l]!=s[r]){
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }
    }
}
public class Solution {
    public bool IsPalindrome(int x) {
        var str = x.ToString();
        if(str.Length==1) return true;
        var l =0;
        var r = str.Length - 1;
        while(r>l){
            if(str[r]!=str[l]) return false;
            r--;
            l++;
        }
        return true;
    }
}
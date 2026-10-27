public class Solution {
    public int ArrangeCoins(int n) {
        int l = 1;
        int r = n;
        int ans = int.MinValue;
        while(l<=r){
            int m = l+(r-l)/2;
            long coins = (long)m*(m+1)/2;
            if(coins>n) r = m-1;
            else {l = m+1; ans = Math.Max(ans, m);}
        }
        return ans;
    }
}
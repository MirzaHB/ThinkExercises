public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int res = right;

        bool canFinish(int n){
            if(n==0) return false;
            long totalTime = 0;
            foreach(int p in piles){
                totalTime += (p+n-1L)/n;
            }
            return totalTime<=h ? true : false;
        }

        while(left<=right){
            int mid = (left+right)/2;
            if(canFinish(mid)){
                right = mid-1;
                res = Math.Min(res, mid);
            }else left = mid+1;
        }
        return res;
    }
}

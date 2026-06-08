public class Solution {
    public long PickGifts(int[] gifts, int k) {
        PriorityQueue<int,int> pq = new();
        var ans = 0;
        foreach(int s in gifts){
            ans+=s;
            pq.Enqueue(-s,-s);
        }

        while(k>0){
            var a = Math.Abs(pq.Dequeue());
            ans -= a;
            var b = (int)Math.Sqrt(a);
            ans += b;
            pq.Enqueue(-b,-b);
            k--;
        }
        return ans;
    }
}
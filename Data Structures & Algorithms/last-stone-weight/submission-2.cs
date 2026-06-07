public class Solution {
    public PriorityQueue<int, int> q = new();
    public int LastStoneWeight(int[] stones) {
        foreach(int s in stones)
            q.Enqueue(-s,-s);
        
        while(q.Count>1){
            var a = q.Dequeue();
            var b = q.Dequeue();

            if(b>a)
                q.Enqueue(a-b, a-b);
        }
        q.Enqueue(0,0);
        return Math.Abs(q.Dequeue());
    }
}

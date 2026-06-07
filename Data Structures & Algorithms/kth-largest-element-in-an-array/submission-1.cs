public class Solution {
    public PriorityQueue<int,int> q = new();
    public int FindKthLargest(int[] nums, int k) {
        foreach(int s in nums)
            q.Enqueue(-s,-s);
        
        for(int i=0; i<k-1; i++){
            q.Dequeue();
        }
        return q.Dequeue()*-1;
    }
}

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> numCount = new();
        foreach(int n in nums)
            numCount[n] = numCount.GetValueOrDefault(n,0)+1;
        
        PriorityQueue<int,int> maxHeap = new();

        foreach(var (key,v) in numCount)
            maxHeap.Enqueue(key,-v);

        int[] ans = new int[k];
        for(int i=0; i<k; i++) ans[i] = maxHeap.Dequeue();

        return ans;
    }
}

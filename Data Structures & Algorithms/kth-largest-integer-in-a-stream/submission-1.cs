public class KthLargest {
    public List<int> heap;
    public int kth;
    public KthLargest(int k, int[] nums) {
        heap = new List<int>();
        heap.Add(0);
        kth = k;
        foreach (int num in nums) {
            Add(num);
        }
    }
    
    public int Add(int val) {
        heap.Add(val);

        var tmp = heap.Count - 1;

        while(heap[tmp] < heap[tmp/2] && tmp>1){
            var newTmp = heap[tmp/2];
            heap[tmp/2] = heap[tmp];
            heap[tmp] = newTmp;
            tmp = tmp/2;
        }
        while(heap.Count > kth+1) pop();
        return heap[1];
    }

    public void pop(){
        if (heap.Count <= 1) return;
        heap[1] = heap[heap.Count-1];
        heap.RemoveAt(heap.Count-1);
        int i = 1;
        while(2*i<heap.Count){
            if(2*i+1<heap.Count && heap[2*i]>heap[2*i+1] && heap[i]>heap[2*i+1]){
                var tmp = heap[i];
                heap[i] = heap[2*i+1];
                heap[2*i+1] = tmp;
                i = 2*i+1;
            }else if(heap[i]>heap[2*i]){
                var tmp = heap[i];
                heap[i] = heap[2*i];
                heap[2*i] = tmp;
                i = 2*i;
            }else break;
        }
    }
}

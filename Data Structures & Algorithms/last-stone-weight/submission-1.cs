public class Solution {
    public List<int> heap = new();
    public int LastStoneWeight(int[] stones) {
        heap = stones.ToList();
        heapify(heap);

        while(true){
            var a = pop();
            var b = pop();
            if(b==null) return a??0;

            if(a==b) continue;
            if(a>b) {ADD(a.Value-b.Value);continue;}
            if(a<b){ADD(b.Value-a.Value); continue;}

            if(heap.Count == 2) return pop() ?? 0;
        }
    }
    public void ADD(int val){
        heap.Add(val);
        var i = heap.Count-1;
        while(i>1){
            if(heap[i/2]<heap[i]){
                var tmp = heap[i/2];
                heap[i/2] = heap[i];
                heap[i] = tmp;
                i = i/2; 
            }else break;
        }
    }

    public void heapify(List<int> nums){
        nums.Add(nums[0]);
        var curr = (nums.Count-1)/2;
        for(int i=curr;i>=1;i--){
            percolateDown(i);
        }
    }

    public void percolateDown(int i){
        while(2*i < heap.Count){
            //right child is heavies between parent and left sibling (swap parent and right kid)
            if(2*i+1<heap.Count && heap[2*i+1]>heap[2*i] && heap[i]<heap[2*i+1]){
                var tmp = heap[i];
                heap[i] = heap[2*i+1];
                heap[2*i+1] = tmp;
                i = 2*i+1;
            }else if(heap[2*i]>heap[i]){    //swap left kid with parent if kid is heavier
                var tmp = heap[i];
                heap[i] = heap[2*i];
                heap[2*i] = tmp;
                i = 2*i;
            }else break;
        }
    }
    public int? pop(){
        if(heap.Count==1) return null;
        var res = heap[1];
        heap[1] = heap[heap.Count-1];
        heap.RemoveAt(heap.Count-1);
        percolateDown(1);
        return res;
    }
}

public class Node{
    public int val=0;
    public Node next = null;
}

public class LinkedList {
    public Node head;
    public Node tail;

    public LinkedList() {
        head = new Node();
        tail = head;
    }

    public int Get(int index) {
        var curr = head.next;
        for(int i=0; i<index; i++){
            if(curr==null) return -1;
            curr = curr.next;
        }
        return curr==null ? -1 : curr.val;
    }

    public void InsertHead(int val) {
        var newNode = new Node();
        newNode.val = val;
        newNode.next = head.next;
        head.next=newNode;
        if(head==tail) tail = newNode;
    }

    public void InsertTail(int val) {
        var newNode = new Node();
        newNode.val = val;
        tail.next = newNode;
        tail= newNode;
    }

    public bool Remove(int index) {
        var curr = head;
        for(int i=0; i<index; i++){
            if(curr==null) return false;
            curr = curr.next;
        }
        if(curr == null || curr.next==null) return false;
        if(tail == curr.next) tail = curr;
        if(curr.next!=null) curr.next = curr.next.next;
        return true;
    }

    public List<int> GetValues() {
        var ans = new List<int>();
        var curr = head.next;
        while(curr != null){
            ans.Add(curr.val);
            curr = curr.next;
        }
        return ans;
    }
}
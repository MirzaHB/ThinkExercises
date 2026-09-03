/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        Queue<Node> q = new();
        if(root!=null) q.Enqueue(root);

        while(q.Any()){
            var qlen = q.Count;
            Node prev = null;
            for(int i=0; i<qlen; i++){
                var curr = q.Dequeue();
                if(curr.left != null) q.Enqueue(curr.left);
                if(curr.right != null) q.Enqueue(curr.right);
                if(prev !=null) prev.next = curr;
                prev = curr;
            }
        }
        return root;
    }
}
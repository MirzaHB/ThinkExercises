/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if(head==null) return null;
        Dictionary<Node, Node> copyNodes = new();

        Node copy(Node og){
            if(copyNodes.ContainsKey(og)) return copyNodes[og];
            var newNode = new Node(og.val);
            copyNodes[og] = newNode;
            if(og.next== null) newNode.next = null;
            else newNode.next = copy(og.next);
            if(og.random == null) newNode.random = null;
            else newNode.random = copy(og.random);

            return newNode;
        }
        return copy(head);
    }
}

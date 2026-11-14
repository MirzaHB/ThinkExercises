/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        Dictionary<int,ListNode> dict = new();
        var curr = head;
        int i;
        for(i=1; curr.next!=null; i++){
            dict[i] = curr;
            curr = curr.next;
        }
        if(dict.Count==0) {head = null; return head;}
        if(i-n<=0){head = head.next; return head;}
        var nodeOfInterest = dict[i-n];
        nodeOfInterest.next = nodeOfInterest.next.next;
        return head;
    }
}

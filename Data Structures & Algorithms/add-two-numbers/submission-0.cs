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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode addLists(ListNode l, ListNode r, int carry){
            if((l==null && r==null) && carry == 0) return null;
            int lVal = l==null? 0 : l.val;
            int rVal = r==null? 0 : r.val;
            int currCarry = 0;
            int currVal = lVal + rVal + carry;
            if(currVal>=10){
                currVal -= 10;
                currCarry = 1;
            }
            var newNode = new ListNode(currVal);
            newNode.next = addLists(l==null? null: l.next , r==null? null: r.next, currCarry);
            return newNode;
        }
        return addLists(l1,l2,0);
    }
}

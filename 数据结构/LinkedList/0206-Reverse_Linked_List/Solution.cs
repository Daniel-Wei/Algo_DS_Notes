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

// Time: 57 ms (79.16%), Space: 40.7 MB (92.78%)

public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null){
            return head;
        }
        
        ListNode curr = head;
        ListNode prev = null;
        ListNode next = null;
        
        while(curr.next != null){
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        
        curr.next = prev;
        
        return curr;
    }
}

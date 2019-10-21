/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        ListNode prev = null;
        ListNode next;
        
        while(head!=null){
            next = head.next;
            head.next = prev;
            prev = head;
            head = next; 
        }
        
        return prev;
        
    }
}
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        ListNode slow = head; 
        ListNode fast = head; 
        
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next; 
        }
        
        slow = reversed(slow);
        fast = head;
        
        while(slow!=null){
            if (slow.val != fast.val){
                return false;
            }
            slow = slow.next;
            fast = fast.next;
        }
        return true;
    }
    
    public ListNode reversed(ListNode head){
        ListNode prev = null; 
        while(head != null){
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }
        return prev;
    }
}
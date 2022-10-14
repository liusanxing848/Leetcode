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
    public bool IsPalindrome(ListNode head) {
        
        if(head == null || head.next == null)
            return true;
               
        ListNode fast = head;
        ListNode slow = head;
        while(fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        
        if(fast != null)
            slow = slow.next; //这里是判定链表长度为奇偶
                
        slow = Reverse(slow);
        fast = head;
        while(slow != null)
        {
            if(fast.val != slow.val)
                return false;
            
            fast = fast.next;
            slow = slow.next;
        }
        
        return true;
    }
    
    private ListNode Reverse(ListNode head) //反转
    {
        ListNode prev = null;
        ListNode next = null;
        ListNode curr = head;
        while(curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        
        return prev;
    }
}
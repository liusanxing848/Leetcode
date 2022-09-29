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
public class Solution 
{
    public ListNode DeleteDuplicates(ListNode head) 
    {
        if(head == null || head.next == null)
        {
            return head;
        }
        
        ListNode finger = new ListNode(-1);
        finger.next = head;
        ListNode curr = finger;
        
        while(curr.next != null)
        {
            int val = curr.next.val;
            while(curr.next.next != null && curr.next.next.val == val)
            {
                curr.next =curr.next.next;
            }
                curr = curr.next;
        }
        return finger.next;
        
    }
}
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
    public void ReorderList(ListNode head) 
    {
        if(head == null)
        {
            return;
        }
        
        ListNode slow = head;
        ListNode fast = head;
        
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        ListNode curr = slow;
        ListNode prev = null;
        while (curr != null)
        {
            ListNode nextNode = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextNode;
        }
        
        ListNode list1 = head;
        ListNode list2 = prev;
        
        while (list2.next != null)
        {
            ListNode tmp = list1.next;
            list1.next = list2;
            list1 = tmp;
            
            tmp = list2.next;
            list2.next = list1;
            list2 = tmp;
        }
        
    }
}
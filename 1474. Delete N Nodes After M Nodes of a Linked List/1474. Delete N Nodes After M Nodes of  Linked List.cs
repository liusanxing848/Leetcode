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
public class Solution //这里要注意上面给的条件，ctor是可以造出来head以前的node
{
    public ListNode DeleteNodes(ListNode head, int m, int n) 
    {
        if (head == null) 
        {
            return null;
        }

        ListNode dummy = new ListNode(0, head);
        ListNode current = dummy;

        while (current != null)
        {
            // Keep the first m nodes
            for (int i = 0; i < m && current != null; i++) 
            {
                current = current.next;
            }

            // Remove the next n nodes
            for (int i = 0; i < n && current != null && current.next != null; i++) 
            {
                current.next = current.next.next;
            }
        }

        return dummy.next;
        
    }
}
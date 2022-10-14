/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution 
{
    
    //一快一慢两个指针，如果链表里面有循环快指针一定会遇到慢指针，因为链表的尾部为循环的开始，所以若有循环则走不完。如果没有循环，链表走一遍就可以遇到null
    public bool HasCycle(ListNode head) 
    {
        if(head == null || head.next == null)
        {
            return false;
        }
        
        ListNode fast = head;
        ListNode slow = head;
        
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if(slow == fast)
            {
                return true;
            }
        }
        
        return false;
    }
}
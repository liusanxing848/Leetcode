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
    public ListNode RemoveElements(ListNode head, int val) 
    {
        if(head == null)
        {
            return head;
        }
        
        ListNode dummy = new ListNode(-1);
        dummy.next = head;
        ListNode p = dummy; //p是遍历指针
        
        while(p.next != null)
        {
            if(p.next.val == val) //当发现目标值
            {
                p.next = p.next.next;//删除并拼接
            }
            else
            {
                p = p.next; //继续往下走
            }
        }
        return dummy.next;
    }
}
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
    public ListNode MiddleNode(ListNode head) 
    {
        if(head.next == null) //边界条件
        {
            return head;
        }

        int counter = 0;
        ListNode node = head;
        while(node.next != null) //先遍历一遍，拿到链表总长度
        {
            node = node.next;
            counter ++;
        }
        int target;
        if(counter % 2 == 0) //找到中点并且处理奇偶问题
        {
            target = counter/2;
        }
        else
        {
            target = counter/2 + 1;
        }

        node = head; //reset node
        for(int i = 0; i < target; i++) //爬到中点就停止，并且返回
        {
            node = node.next;
        }

        return node;
    }
}
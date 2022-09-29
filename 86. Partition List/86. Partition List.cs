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
    public ListNode Partition(ListNode head, int x)
    {
        //创建两个链表，一个装小的值，一个装大的值。
        //然后便利给的链表，小的节点放到小的链表里面，大的节点放到大的链表里面。
        //最后整合一下这两个大小链表
        
        //1. 创建两个链表
        ListNode finger1 = new ListNode(-1);
        ListNode curr1 = finger1;
        
        ListNode finger2 = new ListNode(-1);
        ListNode curr2 = finger2;
        
        //遍历
        while(head != null) //这里head作为移动工作节点。反正最后也不需要它了
        {
            ListNode tempNode = new ListNode(head.val);
            if(head.val < x)
            {
                curr1.next = tempNode;
                curr1 = curr1.next;
            }
            else
            {
                curr2.next = tempNode;
                curr2 = curr2.next;
            }
            head = head.next;
        }
        
        //粘贴两个链表，小值链表在前面，大值链表在后面
        curr1.next = finger2.next; //curr2是在链表的最后面，所以不能搞错了
        return finger1.next;
    }
}
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
    public ListNode RotateRight(ListNode head, int k) 
    {
        if (head == null || head.next == null)   {return head;} //边界条件

        //找到链表的长度
        int length = 1;
        ListNode NodeforCount = head;
        while (NodeforCount.next != null)
        {
            NodeforCount = NodeforCount.next;
            length ++;
        }
        
        //分析k，看k有没有大于链表的长度
        
        //如果k大于链表的长度，也就是说至少循环了N遍
        if (k > length)
        {
            k %= length; //最后的k 位
        }
        
        //此时看是否够幸运，k的值正好在不需要反转的情况下，直接返回链表头
        if (k == length || k == 0) {return head;}
        
        length -= k; //因为是最后k位数，用长度减去最后k位，则为正数的位数
        //rotate logic
        ListNode MoveNextNode = head;
        ListNode PlaceHolderNode = null;
        
        while (length > 0) //这个循环只是那个node一直向下挪动k次
        {
            PlaceHolderNode = MoveNextNode;
            MoveNextNode = MoveNextNode.next;
            length --;
        }
        
        PlaceHolderNode.next = null; //把之前head.next的指针删除
        NodeforCount.next = head;
        
        return MoveNextNode;
        
        
        
    }
}
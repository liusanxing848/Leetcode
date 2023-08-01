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
    public int GetDecimalValue(ListNode head) 
    {
        string biVal = head.val.ToString(); //头值先储存
        ListNode node = head; //dummy
        while(node.next != null) //遍历链表
        {
            biVal += node.next.val.ToString(); //string concate 
            node = node.next;
        }
        return Convert.ToInt32(biVal, 2); //转化
    }
}
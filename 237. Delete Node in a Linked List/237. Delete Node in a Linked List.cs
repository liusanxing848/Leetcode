/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    public void DeleteNode(ListNode node) 
    {
        //当下node既然删不了，那就删下一个
        node.val = node.next.val; 
        node.next = node.next.next;
        
    }
}
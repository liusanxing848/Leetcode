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
    
    //从头走，如果A端走到头就从B端重新走。 B端也是一样。两个指针最后相遇的时候便是交叉点。又是一道数学题
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) 
    {
        if(headA == null || headB == null){return null;}
        
        ListNode fingerA = headA;
        ListNode fingerB = headB;
        
        while(fingerA != fingerB)
        {
            if(fingerA == null)
            {
                fingerA = headB;
            }
            else
            {
                fingerA = fingerA.next;
            }
            
            if(fingerB == null)
            {
                fingerB = headA;
            }
            else
            {
                fingerB = fingerB.next;
            }
        }
        return fingerA;
    }
}
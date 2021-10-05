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
    public ListNode OddEvenList(ListNode head) 
    {
        //边界条件
        if (head == null) {return head;}
        
        ListNode odd = head;
        ListNode even = head.next;
        ListNode evenHead = even;
        
        while(even != null && even.next != null)
        {
            odd.next = even.next; //奇数的下一个应该为偶数，这把奇数的下一个变成了偶数的下一个（也就是奇数）这样奇数的下面都是奇数了
            odd = odd.next; //上一行代码已经把奇数的下一个节点变成奇数，这一行代码为奇数向下移动
            
            even.next = odd.next; //同样，偶数的下面本应该是偶数，现在变成奇数了
            even = even.next; //偶数向下移动
                
        }
        odd.next = evenHead; //把奇数的链表和偶数的链表连起来
        return head;
    }

}
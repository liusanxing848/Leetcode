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
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        //边界条件
        if(head == null)
        {
            return null;
        }
        
        //思路：
        //想要锁定倒数第n个节点，技巧在于用两个链表来实现。
        //第一个链表先从前面缩n个节点，然后在第n个节点开始，与此同时第二个完整的链表从第一个节点同时向后遍历
        //那个从第n节点开始的短链表会提前遇到null，遇到null则停止，这时候停止会造成完整链表（长链表）还差n个节点就遍历结束
        //通过这样的方法就能精确到从后面数第几个节点
        
        ListNode AnswerHead = new ListNode(); //这个是答案返回值节点的基准
        ListNode TempleteRoute = AnswerHead; //templeteroute则为短链表（前段缩n个节点）
        ListNode FullRun = AnswerHead;//完整的长链表，跟着短链表同步向后遍历
        
        AnswerHead.next = head; //定义工作的head
        
        int i = 0;  //i赋值准备开始循环
        
        while ( i < n) //i的大小决定哪短链表缩多少个节点
        {
            TempleteRoute = TempleteRoute.next; //每一次i++就会让短链表的头向后走一格 
            i++;
        }
        
        while(TempleteRoute.next != null) //长短链表都准备好后就开始遍历，遍历的截止点为短链表遇到null
        {
            TempleteRoute = TempleteRoute.next; //向后推进的短链表
            FullRun = FullRun.next; //向后推进的长链表
        }
        
        FullRun.next = FullRun.next.next; //这时候FullRun这个指针会停在倒数第n+1的这个节点上，把.next覆盖一下，缩短一个节点
        
        return AnswerHead.next; //返回
    }
}
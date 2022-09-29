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

 //这道题是除去所有的重复值，一个都不留， 所以移动工作节点不能放置在当下判定的节点上，因为一但是重复的节点， 则没有办法删除，所以要以curr.next 来判定
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        //边界条件，如果这个链表为空或者只有一个节点，则直接返回当下链表
        if(head == null || head.next == null)
        {
            return head;
        }
        
        //curr 为移动工作节点， finger则为最终返回的线头,最终要返回的是finger.next
        ListNode finger = new ListNode(-1);
        finger.next = head;
        ListNode curr = finger;
        
        //业务逻辑：
        while(curr.next != null && curr.next.next != null) 
            //因为curr为移动工作节点，while里面判定的条件是curr最后能留住两个节点，因为curr.next为空则curr为最后一个节点，
            //curr.next.next为空则curr后面还有一个节点，在这种情况可以通过，以为如果只剩下一个肯定不会是重复的值
        {
            if(curr.next.val == curr.next.next.val)
                //如果下一个值和下下一个值相等的时候，在这里，判定两个节点值是否相等是以curr的下一个和下下一个之间来判定，并不是根据curr当下所在的节点上
            {
                int val = curr.next.val;//如果值相等，取出这个值
                while(curr.next != null && curr.next.val == val)
                    //这里的while有两个判定，curr.next不为空则表示链表不能走到头， curr.next.val == val则表示看看接下来到底有多少节点跟当下val的值重复，while里面的逻辑会将curr继续运动下去
                {
                    curr.next = curr.next.next; //此逻辑为如果一直是重复的值，那些重复的的节点会被缩减
                }
            }
            else//此判定是当curr的下一个和下下一个节点并不是重复的值是，curr要向下移动
            {
                curr = curr.next;//向下移动
            }
        }
        
        return finger.next; //因为一开始finger.next等于head，那么返回head
        
        
    }
}
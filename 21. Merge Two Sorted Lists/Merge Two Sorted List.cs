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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        //边界条件， 因为两个链表均为已排序，若其中一个链表为null，则返回另外一个链表
        if (l1 == null)
        {
            return l2;
        }
        
        if(l2 == null)
        {
            return l1;
        }
        
        ListNode temp_head = new ListNode();
        ListNode new_head = temp_head;
        
        while(l1 != null && l2 != null) //一直判定到链表的最后一个节点，l1, l2在操作中分别会向后移动作为新的head
        {
            //哪个节点的值小，这个节点就会成为新的head
            if(l1.val < l2.val) //如果l1值小于l2的值，
            {
                temp_head.next = l1; 
                //temp_head本身不作为头，其.next为头，这样的目的为返回值为一个head，temp_head为了
                //制造（index）新的head会不停的向后移，而循环开始前的new_head则为最终返回的基准。
                
                l1 = l1.next;//原始链表的head被处理过后便没有用了，当下链表的第二个节点则为head。
            }
            else //一切等于或者大于。。。
            {
                temp_head.next = l2;
                l2 = l2.next;
            }
            
            temp_head = temp_head.next; //temp_head在一次循环后则吸收一个节点去做新的链表，吸收后temp_head需要向下
            //挪动一位，准备新的循环
        }
        //while 循环结束后表明至少有一个链表被处理完了。
        
        //如果两个链表的长度一样长，这样是完美的。如果不是一样长，较长的链表剩下没有处理的节点变粘贴到这个新的链表之后，
        //未处理剩下的节点必然都是比处理好的节点的值都大
        
        if(l1 != null) //这个情况是l1链表较长
        {
            temp_head.next = l1; //这时候temp_head不是新的链表的head，因为temp_heady一直向后移动，temp_head在这里是新链表的tail
        }
        
        if(l2 != null)
        {
            temp_head.next = l2; //这个是对称的。不加解释
        }
        
        return new_head.next;
        //因为在最一开始new_head等于temp_head，所以temp_head在处理第一个节点的时候就已经把新的链表head的信息传递
        //给了new_head,只不过新的链表被temp_head表示的永远都是其.next,所以new_head本身为null，但是new_head.next则指向返回链表的head
    }
}
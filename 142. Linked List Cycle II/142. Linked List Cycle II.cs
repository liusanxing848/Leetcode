/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
//特别NB的一道数学题！！！


//先参见141题，这道题里面有一半需要141题的内容，也就是先判断这个链表是否有循环


public class Solution 
{
    public ListNode DetectCycle(ListNode head) 
    {
        if(head == null || head.next == null)
        {
            return null; //边界条件
        }
        
        //开始141题，先判断这个链表是否有循环
        ListNode fast = head;
        ListNode slow = head;
        
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if(slow == fast)
            {
                break; //在这里，141题这一行则为返回true，此题找到了快慢后就在二者相遇的时候停下。（其实是要保留慢指针的位置）
            }
        }
        if(fast == null || fast.next == null) //在141题里面这里直接就返回false，此题因为还有没写完的逻辑，而且返回的不是bool值，所以等于把上面的while判定重新抄写一遍
        {
            return null;//满足这个判定则为链表里面没有循环
        }
        
        //数学公式来证明接下来的逻辑
        //链表中被指向的节点也就是进入循环的分叉点。 
        //m--> 链表的头到分叉点的距离为 m
        //n--> 链表的循环一圈的距离为 n
        //y--> 链表 分叉点 到 相遇点 为 y
        //x--> 相遇点 到 分叉点 x （剩下的路程）
        //k--> k为 快指针 绕了多少圈循环
        //f--> f 为快指针总路程
        //s--> s 为慢指针总路程
        
        //公式推导
        //  f = 2s  （两倍的满指针距离等于一倍的快指针距离）
        //  f = m + kn + y (进入圈之前的距离，加上饶了多少圈的距离， 加上相遇后没走完的那一圈的距离)
        //  s = m + y (进入圈之前的距离， 加上在圈中相遇的距离)
        //  m + kn + y = 2(m + y)
        //  m + kn + y = 2m + 2y
        //  m + kn = 2m + y
        //  kn = m + y
        //  m = kn - y
        //  从分叉点到相遇点的距离（y）等于循环总长减去相遇点 到 未走完的距离（x),所以为 y = n-x
        //  m = kn - (n - x)
        //  m = x + n(k -1)
        // 这就说明 m 到相遇点的距离为 x距离 加上绕 k-1圈的距离。
        // 如果在分叉点开始走，是走不出循环的，那么多走出x的距离 加上k-1 圈就是相遇点
        // 最后把一个指针放在head上面开始走，另外的一个（就是之前相遇后没有动的满指针），这次两个指针走的步幅一样
        
        fast = head;
        while(fast != slow)
        {
            fast = fast.next;
            slow = slow.next;
        }
        
        return fast; //无所谓返回哪个指针
        
    }
}
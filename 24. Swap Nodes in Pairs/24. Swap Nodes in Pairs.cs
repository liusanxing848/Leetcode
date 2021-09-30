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
    public ListNode SwapPairs(ListNode head) 
    {
        if (head == null || head.next == null) {return head;}
       
        
        //Declare: 
        ListNode _old, _new;
        
        _old = head;
        _new = head.next; //far 落在第'二'个节点上,也可以说是一个下一个pair的第二个节点.
        
        head = head.next; //这里的head已经处理好返回了
        
        while (_old != null & _new != null)
        {
            //处理节点的指针
            ListNode node = _new.next; //!!_new是当下未反转pair的头, !!未翻转!! 未翻转!!! 也就是说_new还是属于pair靠后的节//点!!node下一个pair的第一个节点的placeholder
            _new.next = _old;//反转pair的操作. 新头指向被抛弃的老的头
            
            _old.next = node;// 反转后,pair的第二个节点指向下一个未翻转的pair的第一个节点
                
            
            //为了遍历的推进
            if(node !=null && node.next !=null)//因为node永远都是_new的下一个,所以处理好node不能out of range
            {
                _old.next = _old.next.next; //通过node传递指针!! 传递到了下一个pair的新head
                _new = _old.next; //_new跑到下一个pair准备处理下一轮的处理
                _old = node; //node已经说了是二个pair的第一个节点,这里_old也跑到下一个pair准备下一轮的循环
            }
            else
            {
                break;
            }
                    
        }
        return head;
    }
}
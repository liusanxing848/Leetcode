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
    public ListNode ReverseList(ListNode head) 
    {
        if(head == null || head.next == null) {return head;}
        
        ListNode answerNode = head; //新建一个节点，到时候就返回这个节点。
        while( answerNode.next != null) //找到最后一个节点，等到链表反转后，此节点便为head
        {
            answerNode = answerNode.next;
        } //这样的返回方法比较笨，但是想起来很容易
        
        ListNode current = head; //current为当下正在工作的节点
        ListNode previousNode = null; //这个为current前面的节点，让current指向他，这样就保证了反转指针，而且初始值为null，原因是最一开始的head在反转后会变成尾巴，儿尾巴的下一个为null，所以第一波操作的时候head应该去指向null
        
        while (current != null)
        {
            ListNode nextNode = current.next;//这个节点的目的是pin住current以后的链表，当current完成反转指针的动作后，current就要去反转下一个指针，那时候current就会跑到这个nextNode上。所以nextNode 没有事先定义，以为nextNode一直以current的位置为基准
            
            current.next = previousNode; //这一行则为翻转指针的动作。
            previousNode = current;//完成反转指针后，被指向的节点要向后进一位，准备下一次递归
            current = nextNode; //current捡起来预留的位置，向下进一位，准备下一次递归
            
        }
        
        return answerNode; //这个是实现准备好的返回的节点值
        //return previousNode;
        //previousNode 这个节点也可以作为返回值，因为在上面的while循环里面，最后一次循环会让previousNode 变成current，也就是最后一个需要反转的节点，也就是最后链表的head
        
        
        
    }
}
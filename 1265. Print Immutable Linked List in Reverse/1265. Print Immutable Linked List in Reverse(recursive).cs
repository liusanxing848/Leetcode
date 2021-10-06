//***         RECURSIVE METHOD        ***
/**
 * // This is the ImmutableListNode's API interface.
 * // You should not implement it, or speculate about its implementation.
 * class ImmutableListNode {
 *     public void PrintValue(); // print the value of this node.
 *     public ImmutableListNode GetNext(); // return the next node.
 * }
 */

public class Solution 
{
    public void PrintLinkedListInReverse(ImmutableListNode head) 
    {
        if(head == null) //触底条件
        {
            return; //直接返回，void的方法中断
        }
        
        PrintLinkedListInReverse(head.GetNext()); //迭代到最底一层
        
        head.PrintValue(); //每一层所执行的
        
        
    }
}
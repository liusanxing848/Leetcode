/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution 
{
    //深度复制的题，之前原有的节点和其指针都不能作为答案返回，要创建新的节点，然后把这些老节点的值和指针都要复制过去。
    //这道题的思路是把所有的节点都放到dictionary里面，老节点作为key，新节点作为value。
    //先把所有的节点都放到dictionary里，然后再重新建立节点之间的指针。
    
    public Node CopyRandomList(Node head) 
    {
        if(head == null) {return head;}//边界
        
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();//新建dictionary
        
        Node curr = head;
        while(curr != null)
        {
            dict.Add(curr, new Node(curr.val));//把每个节点都放到dictionary里面，value为新建一个节点。
            curr = curr.next;
        }
        
        curr = head;
        while(curr != null) //用老链表的指针来遍历这个链表，要注意的是，这里dictionary的key不能为null
        {
            //老节点的指针等于新节点的指针
            
            
            if(curr.next == null) 
            {
                dict[curr].next = null;
            }
            else
            {
                dict[curr].next = dict[curr.next]; //老节点curr的next的节点就等于当下新节点的next。盒子里盒子外的思路
            }
            
            if(curr.random == null)
            {
                dict[curr].random = null;
            }
            else
            {
                dict[curr].random = dict[curr.random];
            }

            curr = curr.next;
        }
        
        return dict[head];
    }
}
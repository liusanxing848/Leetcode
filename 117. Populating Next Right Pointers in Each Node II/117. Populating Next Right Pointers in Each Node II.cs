/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution 
{
    public Node Connect(Node root) 
    {
        if(root == null) {return root;}
        
        Node head = null; //head是下一层的第一个点
        Node prev = null; //prev是下一层进行连接的点
        Node curr = root;
        
        while(curr != null) //当前层的遍历
        {
            while(curr != null)
            {
                if(curr.left != null)
                {
                    if(head == null)
                    {
                        head = curr.left;
                        prev = curr.left;
                    }
                    else
                    {
                        prev.next = curr.left;
                        prev = prev.next;
                    }
                }
                
                if(curr.right != null)
                {
                    if(head == null)
                    {
                        head = curr.right;
                        prev = curr.right;
                    }
                    else
                    {
                        prev.next = curr.right;
                        prev = prev.next;
                    }
                }
                curr= curr.next; //这一层的while循环，curr会一直向右走，走到头
            }
            curr = head;
            prev = null;
            head = null;//这一层的while循环curr会从下一个新的层重新开始
        }
        
        return root;
    }
}
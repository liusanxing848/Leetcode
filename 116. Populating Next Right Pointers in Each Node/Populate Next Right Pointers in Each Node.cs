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
        if(root == null)
        {
            return root;
        }
        
        Node curr = root; //先让 curr 等于 root
        while(curr != null) //如果curr不等于null说明当前还有节点可以被遍历
        {
            Node head = curr; //head 和 curr反复交替互相传递，每一次的循环head都会跟着向下走一层
            
            while(curr != null)
            {
                if(curr.left != null) //这个block是控制在一侧树左孩子指向右孩子
                {
                    curr.left.next = curr.right;
                }
                
                if(curr.right != null && curr.next != null) //这个block是两个非同父母的树孩子相连
                {
                    curr.right.next = curr.next.left;
                }
                
                curr = curr.next; //最终curr会被指向null，题目已经给出next会被设置成null。而且curr都是坐落在父母节点的位置上工作的
            }
            
            curr = head.left; //curr往下一层走
        }
        return root;
    }
}
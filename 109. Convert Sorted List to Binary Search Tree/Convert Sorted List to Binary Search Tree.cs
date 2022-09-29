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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{
    public TreeNode SortedListToBST(ListNode head)
    {
        if(head == null)
        {
            return null;
        }
        return helper(head, null);
    }
    
    private TreeNode helper(ListNode start, ListNode end)
        {
        //找中点，利用快慢指针来找中点
            if(start == end)
            {
                return null;
            }
            
            //找中点
            ListNode slow = start; //一开始的慢指针从head开始，这个start一开始会传进来head
            ListNode fast = start; 
            
            while(fast != end && fast.next != end) //在正常的情况下，这个快指针是触碰到null来决定结束。因为这里会用到recursive所以也就用end来封尾
            {
                slow = slow.next; //while循环结束后，slow则为中点
                fast = fast.next.next;
            }
            
            TreeNode root = new TreeNode(slow.val);
            root.left = helper(start, slow);
            root.right = helper(slow.next, end);
            return root;
        }
}
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

//迭代
public class Solution 
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) 
    {
        if(root1 == null) {return root2;} //如果root1为空，则返回root2
        if(root2 == null) {return root1;} //反之亦然
        
        root1.val += root2.val; //不要二号树，二号树的节点值直接合并到一号树
        root1.left = MergeTrees(root1.left, root2.left); //一号树当下节点的左孩子是树1当下节点左孩子加上树2当下节点右孩子的值。如此迭代下去。每一次迭代都会把当下节点的左孩子的值加和完毕
        root1.right = MergeTrees(root1.right, root2.right); //右孩子同上
        
        return root1;  //返回root1，树1最顶端。虽然迭代，root1不会被改变
    }
}
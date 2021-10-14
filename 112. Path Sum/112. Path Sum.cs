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
    public bool HasPathSum(TreeNode root, int targetSum) 
    {
        //边界条件1： null
        if(root == null) {return false;}
        
        //边界条件2：
        //同时也是业务逻辑的判定：
        //root正好等于target值。这道题判定条件是root到leaf，如果root左右有孩子则不可以。但是如果只有一个root，这样root也可以做leaf。
        if(root.left == null && root.right == null && root.val == targetSum) {return true;}
        
         //开始迭代
        //返回值只能是一个，这道题的method返回值为一个bool value，所以用or只要有一个符合条件返回即可
        //业务逻辑：
        //当迭代的时候，sum会一直做减法，一直减左孩子们，或者右孩子们。当迭代触及到leaf的时候，也就是最深的那一个节点的时候正好那个节点的值和被一直做减法的sum值相等（正好相减为零）。这样左右孩子都没有，还能正好减到零，所以满足上一行代码的条件，会返回true。这也是就决定了整个method的返回值
        return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
    }
}
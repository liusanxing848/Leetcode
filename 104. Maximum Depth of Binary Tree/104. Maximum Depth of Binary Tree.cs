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
    public int MaxDepth(TreeNode root) 
    {
        
        //边界条件
        if (root == null) {return 0;}
        
        //使用DFS方法
        else
        {
            int L;
            int R;
            
            L = MaxDepth(root.left); //左侧到底
            R = MaxDepth(root.right); //右侧到底
            
            
            if (L > R) {return L + 1;} //哪一侧数字大则为树的高度
            else        {return R + 1;}
            
        }
        
    }
}
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
public class Solution {
    public bool answer = true; //先声明，在后面不平衡发现的时候则改变这个值
    
    public bool IsBalanced(TreeNode root) 
    {
        if (root == null) {return true;} //边界条件
            
        
        DFS(root); //运行自定义的DFS,如果不平衡，这个method里面会有代码处理answer
        
        return answer;//如果DFS这个method运行成功边说明里面的answer没有被变成false，也就是说没有看到不平衡的树，代码则之间返回answer的默认值
    }
    
    private int DFS(TreeNode node) //新建可以recursive 的method
    {
        if (node == null) {return 0;} 
                    
        
        int L = DFS(node.left); //左孩子的递归
        int R = DFS(node.right);//右孩子的递归
        
        if (Math.Abs(L - R) > 1) //如果左右侧相差大于1时，树则不平衡
        {
            answer = false; //不平衡就改动最终返回值
        }
            
        return Math.Max(L, R) + 1; 
    }
}
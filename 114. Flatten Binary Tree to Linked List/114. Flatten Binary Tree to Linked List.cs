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
    public void Flatten(TreeNode root) 
    {
        //用stack来做，因为是先贴左面，再贴右面（preorder），所以用stack先装右面再装左面
        //此题要求要在原有的树上面作为改动，而且最终的效果是只有右侧的树
        if(root == null)
        {
            return;
        }
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.push(root);
        
        while(!stack.isEmpty())
        {
            TreeNode curr = stack.pop();
            if(curr.right != null)
            {
                stack.push(curr.right)
            }
            
            if(curr.left != null)
            {
                stack.push(curr.left);
            }
            
            if(!stack .isEmpty())
            {
                curr.right = stack.peek(); //为了避免从stack里面拿出来找不到，用peek手段先把最上面的元素贴到root上
            }
            
            curr.left = null; //删除左分支
        }
        
    }
}
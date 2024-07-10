/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution 
{
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) 
    {
        if(original == null || cloned == null || target == null) //edge case
        {
            return null;
        }

        if(original.val == target.val) 
        {
            return cloned;
        }

        //递归的时候original 和 cloned 同时递归。
        //递归走两侧，左侧和右侧，每一次递归都要运行上面block的代码进行验证，如果发现相同的值，则返回cloned的那个节点。
        TreeNode left = GetTargetCopy(original.left, cloned.left, target);
        TreeNode right = GetTargetCopy(original.right, cloned.right, target);

        if(left != null)
        {
            return left; //这里是为下一次递归所返回的节点，如果不返回，则下一轮的递归无法进行下去
        }

        if(right != null)
        {
            return right;//同上，为下一次递归返回值
        }

        if(cloned.left == null && cloned.right == null)//这种情况是树的左右侧都递归到底了，没有节点，那么这时候也不会有匹配的值了。直接返回null
        {
            return null;
        }

        return null;
    }
}
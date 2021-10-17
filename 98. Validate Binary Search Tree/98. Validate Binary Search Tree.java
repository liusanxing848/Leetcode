/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    //new method
    public boolean checkValidation(TreeNode node, Integer min, Integer max) {
        if (node == null) {
            return true;
        }
        
        if ((max != null && node.val >= max) || (min != null && node.val <= min)) {
            return false;
        }
        
        boolean isLeftValid = checkValidation(node.left, min, node.val);
        boolean isRightValid = checkValidation(node.right, node.val, max);
        
        return isLeftValid && isRightValid;
    }
    
    public boolean isValidBST(TreeNode root) {
        return checkValidation(root, null, null);
    }
}
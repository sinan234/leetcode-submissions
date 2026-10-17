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

    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;

        int leftmax =0;
        int rightmax =0;
        
        leftmax= MaxDepth(root.left);
        rightmax= MaxDepth(root.right);

       return 1 + Math.Max(leftmax,rightmax);
    }

}

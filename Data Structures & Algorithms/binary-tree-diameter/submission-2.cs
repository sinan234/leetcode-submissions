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
                int d = 0;

    public int DiameterOfBinaryTree(TreeNode root) {
        if(root == null) return 0;

        int leftheight =0;
        int rightheight =0;

        leftheight = HeightOfBinaryTree(root.left);
        rightheight = HeightOfBinaryTree(root.right);

        d =  Math.Max(leftheight + rightheight, d);

        DiameterOfBinaryTree(root.left);
        DiameterOfBinaryTree(root.right);

        return d;
    }

    public int HeightOfBinaryTree(TreeNode root) {
        if(root == null) return 0;

        int leftheight =0;
        int rightheight =0;

        leftheight = HeightOfBinaryTree(root.left);
        rightheight = HeightOfBinaryTree(root.right);

        return 1+ Math.Max(leftheight , rightheight);
    }
}

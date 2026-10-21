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
    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;

        int left= Height(root.left);
        int right = Height (root.right);

        if(left -right >1 || right-left >1) return false;

        bool a =IsBalanced(root.left);
        bool b =IsBalanced(root.right);

        return a==true && b==true;
    }

    public int Height(TreeNode node){
        if(node == null) return 0;

        int left = Height(node.left);
        int right=Height(node.right);

        return 1+ Math.Max(left, right);
    }
}

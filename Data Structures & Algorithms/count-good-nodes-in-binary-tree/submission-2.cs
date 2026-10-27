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
    int max =0;
    int good = 0;

    public int GoodNodes(TreeNode root) {
        if(root == null) return 0;
        Count(root,root.val);
        return good;
    }

    public void Count(TreeNode root, int max){
        if(root.val >= max){
            good+=1;
            max=root.val;
        }

        if(root.left!=null) Count(root.left, max);
        if(root.right!=null) Count(root.right,  max);

    }
}

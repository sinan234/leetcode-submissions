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
    public bool IsValidBST(TreeNode root) {
        return CheckValid(root, int.MinValue, int.MaxValue);
    }

    public bool CheckValid(TreeNode root , int min , int max){
        if(root == null) return true;

        if((root.val <=min || root.val >=max)) return false;

        bool a = CheckValid(root.left,min, root.val);
        bool b = CheckValid(root.right, root.val, max);

        return a== true && b==true;
    }

}

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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null && subRoot ==null) return true;
        else if(root == null && subRoot !=null) return false;
        else if(root != null && subRoot ==null) return true;

        bool a = sameTree(root, subRoot);
        if (a) return a;

        else{
           bool b = IsSubtree(root.left, subRoot);
           if (b) return b;
           else{
                bool c = IsSubtree(root.right, subRoot);
                return c;
           }
        }
    }

    public bool sameTree(TreeNode root1, TreeNode root2){
        if(root1 == null && root2 == null) return true;
        else if((root1 !=null && root2==null) || (root1 ==null && root2!=null)) return false;
        else if(root1.val !=  root2.val) return false;

            bool left = sameTree(root1.left, root2.left);
        

            bool right = sameTree(root1.right, root2.right);
        

        return left == true && right == true ;
    }
}

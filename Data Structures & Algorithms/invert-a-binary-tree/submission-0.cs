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
    public TreeNode InvertTree(TreeNode root) {
        TreeNode current = root;
        Stack<TreeNode> s = new Stack<TreeNode>();
        s.Push(root);

        while(s.Count >0){
            root = s.Pop();
            
            if(root !=null){
                TreeNode left = root.left;
                root.left = root.right;
                root.right = left;
                
                if(root.left!=null) s.Push(root.left);
                if(root.right!=null) s.Push(root.right);
            }
        }

        return current;
    }
}

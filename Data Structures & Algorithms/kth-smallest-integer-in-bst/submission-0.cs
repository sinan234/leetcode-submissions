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
    Stack<TreeNode> s = new Stack<TreeNode>();
    int index =0;

    public int KthSmallest(TreeNode root, int k) {
            TreeNode current = root;

        while(root !=null || s.Count >0){
            while(current != null){
                s.Push(current);
                current = current.left;
            }

            current =s.Pop();
            index++;

            if(index == k){
                return current.val;
            }
            
            current =current.right;
        }
        return -1;
    }
}

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
    List<int> res = new List<int>();
    Queue<TreeNode> q = new Queue<TreeNode>();
    public List<int> RightSideView(TreeNode root) {
        if(root != null) q.Enqueue(root);
        
        while(q.Count > 0){
            int size = q.Count;
            TreeNode current = new TreeNode();

            while(size >0){

                current = q.Dequeue();

                if(current.left!=null){
                    q.Enqueue(current.left);
                }
                if(current.right !=null){
                    q.Enqueue(current.right);
                } 

                size--;
            }
            res.Add(current.val);

        }

        return res;

    }
}

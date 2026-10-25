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
    List<List<int>> res = new   List<List<int>>();
    Queue<TreeNode> q = new Queue<TreeNode>();
    int size =0;

    public List<List<int>> LevelOrder(TreeNode root) {
        if(root != null){
            q.Enqueue(root);

            while(q.Count > 0){
                size = q.Count;
                List<int> level = new List<int>();
                while(size > 0){
                    TreeNode current = q.Dequeue();
                    
                    level.Add(current.val);

                    if(current.left!=null){
                        q.Enqueue(current.left);
                    }
                    if(current.right!=null){
                        q.Enqueue(current.right);
                    }
                    size--;
                }
                res.Add(level);

            }
        }
        return res;
    }
}

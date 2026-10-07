/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode();
        ListNode res = dummy;

        ListNode left = list1;
        ListNode right = list2;

        while(left != null && right !=null){
            if(left.val< right.val){
                res.next = left;
                left = left.next;
            }
            else{
                res.next = right;
                right = right.next;
            }
            res=res.next;

        }

                res.next = left ?? right;
        return dummy.next;
        
    }
}
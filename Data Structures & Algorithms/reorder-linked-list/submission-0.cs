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
    public void ReorderList(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;


        while(fast!=null && fast.next !=null){
            slow = slow.next;
            fast= fast.next.next;
        }

        ListNode first = head;

        ListNode second = slow.next;
        slow.next = null;

        ListNode current = second;
        ListNode prev = null;

        while(current != null){
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }


        while(prev!=null ){
                ListNode savedfirst = first.next;
                ListNode savedsecond = prev.next;
                first.next = prev;
                prev.next = savedfirst;
             
             first = savedfirst;
             prev = savedsecond;

        }
    }
}

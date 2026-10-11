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
    public bool HasCycle(ListNode head) {
        ListNode start = head;
        HashSet<ListNode> h = new HashSet<ListNode>();

        while(start != null){
            Console.WriteLine($"start val is {start.val}");

            if(h.Contains(start.next)){
                return true;
            }

            h.Add(start);

            start= start.next;
            
        }
        return false;
        
    }
}

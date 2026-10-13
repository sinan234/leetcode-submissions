/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if(head == null) return null;
        Node test = head;
        Node c = head;

        Dictionary<Node,Node> d = new  Dictionary<Node,Node>();
        
        while(head != null){
            d.Add(head, new Node(head.val));
            head = head.next;
        }

        while(test != null){
            Node res = d[test];

            if(test.next!=null) res.next = d[test.next];
            if(test.random !=null) res.random = d[test.random];
            
    
            test = test.next;
        }

        return d[c];
    }
}

package LinkedList.ListCycle;

import LinkedList.ListNode;

import java.util.HashSet;

public class ListCycle {
    public ListNode detectCycle(ListNode a) {

        ListNode curr = a;
        HashSet<ListNode> map = new HashSet<>();

        while(curr != null) {

            if(map.contains(curr)) {
                return curr;
            }
            else {
                map.add(curr);
            }

            curr = curr.next;
        }

        return null;
    }
}

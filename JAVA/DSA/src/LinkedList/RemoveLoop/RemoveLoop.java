package LinkedList.RemoveLoop;

import LinkedList.ListNode;

import java.util.HashMap;

public class RemoveLoop {
    public static ListNode solve(ListNode A) {

        ListNode curr = A, prev = A;
        HashMap<ListNode, Integer> map = new HashMap<>();

        while(curr != null) {

            if(map.containsKey(curr)) {
                prev.next = null;
                break;
            }
            else {
                map.put(curr,1);
            }

            prev = curr;
            curr = curr.next;
        }

        return A;
    }
}
package LinkedList.ReverseLinkedListII;
import LinkedList.ListNode;
public class ReverseLinkedListII {
    public static ListNode begin = null;
    public static ListNode close = null;
    public static ListNode prev = null;
    public static ListNode start = null;
    public static ListNode end = null;
    public static ListNode reverseBetween(ListNode A, int B, int C) {

        begin = null; close = null; prev = null; start = null; end = null;

        start = A; end = null; prev = null;
        int count = 1;

        //Create the start and the end node for the reversal
        while(count < B) {
            prev = start;
            begin = prev;
            start = start.next;
            count++;
        }

        if(count==1) {
            start = A; end = A;
        }
        else {
            end = start;
        }

        close = start;

        while(count < C + 1) {
            end = end.next;
            count++;
        }

        ListNode node = reverse(A,start,end);

        return node;
    }

    public static ListNode reverse(ListNode A, ListNode start, ListNode end) {

        ListNode curr, next;

        curr = start;

        while(start != end) {

            curr = start.next;
            start.next = prev;
            prev = start;
            start = curr;

            if(start == null) { break; }
        }

        if(begin != null) {
            begin.next = prev;

        }
        else {
            A = prev;
        }

        close.next = start;

        return A;
    }
}
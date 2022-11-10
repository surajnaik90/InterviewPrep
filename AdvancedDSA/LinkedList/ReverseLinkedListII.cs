/*
Reverse a linked list A from position B to C.

NOTE: Do it in-place and in one-pass.

Problem Constraints
1 <= |A| <= 106

1 <= B <= C <= |A|

Input Format
The first argument contains a pointer to the head of the given linked list, A.

The second arugment contains an integer, B.

The third argument contains an integer C.

Output Format
Return a pointer to the head of the modified linked list.

Example Input
Input 1:

 A = 1 -> 2 -> 3 -> 4 -> 5
 B = 2
 C = 4

Input 2:

 A = 1 -> 2 -> 3 -> 4 -> 5
 B = 1
 C = 5

Example Output
Output 1:

 1 -> 4 -> 3 -> 2 -> 5
Output 2:

 5 -> 4 -> 3 -> 2 -> 1

Example Explanation
Explanation 1:

 In the first example, we want to reverse the highlighted part of the given linked list : 1 -> 2 -> 3 -> 4 -> 5 
 Thus, the output is 1 -> 4 -> 3 -> 2 -> 5 
Explanation 2:

 In the second example, we want to reverse the highlighted part of the given linked list : 1 -> 4 -> 3 -> 2 -> 5  
 Thus, the output is 5 -> 4 -> 3 -> 2 -> 1  
 */

public static class ReverseLinkedListII
{
    public static ListNode solve(ListNode A, int B, int C)
    {
        if (A.next == null || B == C) {
            return A;
        }

        ListNode head = A, prevNodeB = A, postNodeC = A;

        int count = 0;
        while (head != null) {
            count++;
            if (count == B-1) {
                prevNodeB = head;
            }
            if(count == C || head == null) {
                postNodeC = head;
            }

            head = head.next;
        }

        int length = C - B + 1;
        head = Reverse(prevNodeB.next, postNodeC);
        prevNodeB.next = head;

        count = 1;
        while(count < length) {
            head = head.next;
            count++;
        }

        head.next = postNodeC;

        return A;
    }

    public static ListNode Reverse(ListNode A, ListNode endNode)
    {
        if (A.next == null) {
            return A;
        }

        ListNode l = A, mid = A.next, r;

        if (A.next.next != null) {
            r = A.next.next;
        }
        else {
            mid.next = l;
            l.next = null;
            return mid;
        }

        ListNode head = r; l.next = null;
        while (r != endNode) {

            mid.next = l;
            l = mid;
            mid = r;
            head = r;
            r = r.next;
        }

        mid.next = l;
        l = mid;

        return head;
    }
}
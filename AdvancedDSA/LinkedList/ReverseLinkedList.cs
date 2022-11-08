/*
You are given a singly linked list having head node A. 
You have to reverse the linked list and return the head node of that reversed list.

NOTE: You have to do it in-place and in one-pass.

Problem Constraints
1 <= Length of linked list <= 105

Value of each node is within the range of a 32-bit integer.

Input Format
First and only argument is a linked-list node A.

Output Format
Return a linked-list node denoting the head of the reversed linked list.

Example Input
Input 1:

 A = 1 -> 2 -> 3 -> 4 -> 5 -> NULL 
Input 2:

 A = 3 -> NULL 

Example Output
Output 1:

 5 -> 4 -> 3 -> 2 -> 1 -> NULL 
Output 2:

 3 -> NULL 

Example Explanation
Explanation 1:

 The linked list has 5 nodes. After reversing them, the list becomes : 5 -> 4 -> 3 -> 2 -> 1 -> NULL 
Expalantion 2:

 The linked list consists of only a single node. After reversing it, the list becomes : 3 -> NULL 
 */

public static class ReverseLinkedList
{
    public static ListNode solve(ListNode A)
    {
        if (A.next == null) {
            return A;
        }

        ListNode l = A, mid = A.next, r;

        if(A.next.next != null) {
            r = A.next.next;
        }
        else {
            mid.next = l;
            l.next = null;
            return mid;
        }

        ListNode head = r; l.next = null;
        while (r != null) {

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
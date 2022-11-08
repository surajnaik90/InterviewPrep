/*
Given a sorted linked list, delete all duplicates such that each element appears only once.

Problem Constraints
0 <= length of linked list <= 106

Input Format
First argument is the head pointer of the linked list.

Output Format
Return the head pointer of the linked list after removing all duplicates.

Example Input
Input 1:

 1->1->2
Input 2:

 1->1->2->3->3

Example Output
Output 1:

 1->2
Output 2:

 1->2->3

Example Explanation
Explanation 1:

 Each element appear only once in 1->2.
 */

public static class RemoveDuplicates
{
    public static ListNode solve(ListNode A)
    {
        if (A.next == null) {
            return A;
        }

        ListNode head = A, prevNode = head, tempNode;

        while(head != null) {

            tempNode = prevNode;

            while((tempNode.val == head.val) && (head.next != null)) {
                head = head.next;
            }

            if (head.next == null) {

                if(prevNode.val != head.val) {
                    prevNode.next = head;
                }
                else {
                    prevNode.next = null;
                }
                break;
            }

            prevNode.next = head;
            prevNode = prevNode.next;
            head = head.next;
        }

        return A;
    }
}
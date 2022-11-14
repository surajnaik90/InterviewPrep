/*
Sort a linked list, A in O(n log n) time using constant space complexity.

Problem Constraints
0 <= |A| = 105

Input Format
The first and the only arugment of input contains a pointer to the head of the linked list, A.

Output Format
Return a pointer to the head of the sorted linked list.

Example Input
Input 1:

A = [3, 4, 2, 8]
Input 2:

A = [1]

Example Output
Output 1:

[2, 3, 4, 8]
Output 2:

[1]

Example Explanation
Explanation 1:

 The sorted form of [3, 4, 2, 8] is [2, 3, 4, 8].
Explanation 2:

 The sorted form of [1] is [1]. 
 */

public static class SortList
{
    public static ListNode solve(ListNode A)
    {
        return mergeSort(A);
    }
    public static ListNode mergeSort(ListNode node)
    {
        if (node == null) { return null; }

        if(node.next == null) { return node; }

        ListNode mid = getMidNode(node);

        ListNode A = node, B = mid.next;
        mid.next = null;

        if (A.next == mid) { return A; }

        ListNode half1 = mergeSort(A);
        ListNode half2 = mergeSort(B);

        ListNode head = MergeLists.solve(half1, half2);

        return head;
    }
    public static ListNode getMidNode(ListNode node)
    {
        ListNode slow = node, fast = node;

        while(fast != null && fast.next != null) {

            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}
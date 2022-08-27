/*
Given a matrix A of size Nx3 representing operations. Your task is to design the linked list based on these operations.

There are four types of operations:

0 x -1: Add a headnode of value x before the first element of the linked list. After the insertion, the new headnode will be the 
first headnode of the linked list.
1 x -1: Append a headnode of value x to the last element of the linked list.
2 x index: Add a headnode of value x before the indexth headnode in the linked list. If index equals to the length of linked list, 
the headnode will be appended to the end of linked list. If index is greater than the length, the headnode will not be inserted.
3 index -1: Delete the indexth headnode in the linked list, if the index is valid.
A[i][0] represents the type of operation.

A[i][1], A[i][2] represents the corresponding elements with respect to type of operation.

Note: Indexing is 0 based.

Problem Constraints
1 <= Number of operations <= 1000
1 <= All headnode values <= 109

Input Format
The only argument given is matrix A.

Output Format
Return the pointer to the starting of the linked list.

Example Input
Input 1:
    A = [   [0, 1, -1]
            [1, 2, -1]
            [2, 3, 1]   ]
Input 2:
    A = [   [0, 1, -1]
            [1, 2, -1]
            [2, 3, 1]
            [0, 4, -1]
            [3, 1, -1]
            [3, 2, -1]  ]

Example Output
Output 1:
    1->3->2->NULL
 
Output 2:
    4->3->NULL

 */
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        this.val = x; 
        this.next = null;
    }
}
public static class DesignLinkedList
{
    static ListNode head = null;
    public static ListNode operation(List<List<int>> A)
    {
        for (int i = 0; i < A.Count; i++) {

            switch (A[i][0]) {
                case 0:
                    insert_node(0, A[i][1]);
                    break;
                case 1:
                    insert_node(int.MaxValue, A[i][1]);
                    break;
                case 2:
                    insert_node(A[i][2], A[i][1]);
                    break;
                case 3:
                    delete_node(A[i][1]);
                    break;
            }
        }
        return head;
    }

    public static void insert_node(int position, int value)
    {
        ListNode node = new ListNode(value);

        //Insert at the beginning
        if (head == null) {
            head = node;
            return;
        }

        ListNode temp = head, prevNode = null; int i = 0;
        while (temp != null) {
            if (i == position) {
                if (i == 0){
                    node.next = head;
                    head = node;
                }
                else {
                    prevNode.next = node;
                    node.next = temp;
                }
                return;
            }
            prevNode = temp;
            temp = temp.next;
            i++;
        }
        //Insert last
        if (i == position) {
            prevNode.next = node;
        }

        if (position == int.MaxValue) {
            prevNode.next = node;
        }
    }

    public static void delete_node(int position)
    {
        ListNode node = null;

        if (head == null) {
            return;
        }

        ListNode temp = head, prevNode = null; int i = 0;
        while (temp != null) {

            if (i == position) { 
                if (i == 0) {
                    head = head.next;
                }
                else {
                    prevNode.next = temp.next;
                }
                return;
            }
            prevNode = temp;
            temp = temp.next;
            i++;
        }

        //Delete last
        if (i == position) {
            prevNode.next = null;
        }
    }
}
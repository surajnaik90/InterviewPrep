/*
Design and implement a Linked List data structure.
A node in a linked list should have the following attributes - an integer value and a pointer to the next node.
It should support the following operations:

insert_node(position, value) - To insert the input value at the given position in the linked list.
delete_node(position) - Delete the value at the given position from the linked list.
print_ll() - Print the entire linked list, such that each element is followed by a single space.
Note:

If an input position does not satisfy the constraint, no action is required.
Each print query has to be executed in a new line.

Problem Constraints
1 <= value <= 105
1 <= position <= n where, n is the size of the linked-list.

Input Format
First line contains an integer denoting number of cases, let's say t.
Next t line denotes the cases.

Output Format
When there is a case of print_ll(),  Print the entire linked list, such that each element is followed by a single space.
NOTE: You don't need to return anything.

Example Input
5
i 1 23
i 2 24
p
d 1
p

Example Output
23 24
24

Example Explanation
After first two cases linked list contains two elements 23 and 24.
At third case print: 23 24.
At fourth case delete value at first position, only one element left 24.
At fifth case print: 24.
 */

public static class LinkedList
{
    static ListNode head = null;
    public static void insert_node(int position, int value)
    {
        ListNode node = new ListNode(value);        

        //Insert at the beginning
        if (head == null) {
           head = node;
           return;
        }

        ListNode temp = head, prevNode=null; int i = 1;
        while (temp != null) {

            if (i == position) {

                if (i == 1) {
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
    }

    public static void delete_node(int position)
    {
        ListNode node = null;

        if (head == null) {
            return;
        }

        ListNode temp = head, prevNode = null; int i = 1;
        while (temp != null) {

            if (i == position) {

                if (i == 1) {
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

    public static void print_ll()
    {
        ListNode temp = head;

        int i = 0;
        while(temp!=null) {

            if (i > 0) {
                Console.Write(" ");
            }
            Console.Write(temp.val);
            temp = temp.next;
            i++;
        }
    }
}
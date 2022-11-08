﻿/*
Given a singly linked list, delete middle of the linked list.

For example, if given linked list is 1->2->3->4->5 then linked list should be modified to 1->2->4->5

If there are even nodes, then there would be two middle nodes, we need to delete the second middle element.

For example, if given linked list is 1->2->3->4->5->6 then it should be modified to 1->2->3->5->6.

Return the head of the linked list after removing the middle node.

If the input linked list has 1 node, then this node should be deleted and a null node should be returned.


Input Format

The only argument given is the node pointing to the head node of the linked list
 */

public static class DeleteMiddleNode
{
    public static ListNode solve(ListNode A)
    {
        ListNode head = A; int count = 0;

        while(head != null) {
            count++;
            head = head.next;
        }

        int mid = count / 2;
        if (mid == 0) {
            return null;
        }

        head = A; count = 0; ListNode prevNode = head;

        while (head != null) {

            ListNode tempNode = head;

            if(count == mid) {
                prevNode.next = tempNode.next;
                break;
            }

            count++;
            prevNode = head;
            head = head.next;
        }

        return A;
    }
}
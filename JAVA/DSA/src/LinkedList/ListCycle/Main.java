package LinkedList.ListCycle;

import LinkedList.ListNode;
import LinkedList.RemoveLoop.RemoveLoop;

public class Main {
    public static void main(String[] args) {

        ListNode node1 = new ListNode(3);
        ListNode node2 = new ListNode(2);
        ListNode node3 = new ListNode(4);
        ListNode node4 = new ListNode(5);
        ListNode node5 = new ListNode(6);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;
        node5.next = node3;

        System.out.println("Printing the input linked list");
        //printLinkedList(node1);

        ListNode ans = RemoveLoop.solve(node1);

        System.out.println("Printing the output:");
        printLinkedList(ans);
    }

    public static void printLinkedList(ListNode node) {

        while(node != null) {
            if(node.next != null) {
                System.out.print(node.val + "->");
            }
            else{
                System.out.print(node.val);
            }
            node = node.next;
        }
    }
}

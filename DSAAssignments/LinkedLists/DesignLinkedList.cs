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

    public static ListNode operation(List<List<int>> A)
    {
        ListNode headnode = null, tailnode = null, newnode = null;
        int length = 0, index;

        for (int i = 0; i < A.Count; i++) {

            int element; 
            switch (A[i][0])
            {
                case 0:
                    //Insert node at the beginning
                    element = A[i][1];
                    newnode = new ListNode(element);

                    if(headnode == null) {
                        headnode = newnode;
                        tailnode = headnode;
                        length = 1;
                        break;
                    }
                    else {
                        newnode.next = headnode;
                        headnode = newnode;
                    }
                    break;
                
                case 1:
                    //Insert node at the end
                    element = A[i][1]; newnode = new ListNode(element);

                    if(headnode == null) {
                        headnode = newnode;
                        tailnode = headnode;
                        length = 1;
                        break;
                    }
                    if (tailnode == headnode) {
                        ListNode tempnode = headnode;
                        while (tempnode.next != null) {
                            tempnode = tempnode.next;
                            length++;
                        }
                        tempnode.next = newnode;
                        tailnode = newnode;
                    }
                    else {
                        tailnode.next = newnode;
                        tailnode = newnode;
                    }
                    break;

                case 2:
                    index = A[i][2]; element = A[i][1];
                    newnode = new ListNode(element);

                    break;
                
                case 3:

                    break;
            }
        }


        return headnode;
    }

    public static ListNode solve(List<List<int>> A)
    {
        ListNode headnode = null, tailnode=null; int element, index;

        for (int i = 0; i < A.Count; i++) {

            switch (A[i][0])
            {
                case 0:
                    element = A[i][1];
                    ListNode insertheadnode = new ListNode(element);
                    insertheadnode.next = headnode;
                    headnode = insertheadnode;
                    break;

                case 1:
                    element = A[i][1];

                    if (headnode == null) { 
                        headnode = new ListNode(element);
                        break;
                    }

                    ListNode tempnode = headnode;
                    while (tempnode.next != null) {
                        tempnode = tempnode.next;
                    }
                    ListNode tail = new ListNode(element);
                    tempnode.next = tail;
                    tailnode = tail;
                    break;

                case 2:
                    element = A[i][1]; index = A[i][2];

                    ListNode insertindexnode = new ListNode(element);

                    if (headnode == null) { headnode = insertindexnode; break; };
                    
                    ListNode indexthnode = headnode, previndexnode = headnode, prevnode=headnode;
                    ListNode tempinsertnode = headnode;
                    int count = 0, j=0;
                    while (tempinsertnode != null) {
                        
                        if (j == index){
                            previndexnode = prevnode;
                            indexthnode = tempinsertnode.next;
                        }
                        count++; j++;
                        prevnode = tempinsertnode;
                        tempinsertnode = tempinsertnode.next;
                    }
                    if (index == count) {
                        prevnode.next = insertindexnode;
                    }
                    else if(index < count) {
                        previndexnode.next = insertindexnode;
                        insertindexnode.next = prevnode;
                    }
                    break;

                case 3:
                    index = A[i][1];

                    if (headnode == null) { break; }

                    ListNode prevdeletenode=null, tempdeletenode = headnode;
                    int cnt = 0, k = 0; 
                    
                    while (tempdeletenode != null) {

                        if (k == index) {

                            if (prevdeletenode != null) {
                                prevdeletenode.next = tempdeletenode.next;
                            }
                            else {
                                headnode = headnode.next;
                            }
                            break;
                        }

                        prevdeletenode = tempdeletenode;
                        tempdeletenode = tempdeletenode.next;
                        cnt++;k++;
                    }
                    break;

                default: 
                    break;
            }
        }
        return headnode;
    }
}
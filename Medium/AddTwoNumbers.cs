/*
 You are given two non-empty linked lists representing two non-negative integers.
 The digits are stored in reverse order, and each of their nodes contains a single digit. 
 Add the two numbers and return the sum as a linked list.

 You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 Input: l1 = [2,4,3], l2 = [5,6,4]
 Output: [7,0,8]
 Explanation: 342 + 465 = 807.
*/
public static class AddTwoNumbers
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
      {
            this.val = val;
            this.next = next;
      }

     }
    public static ListNode Operation1(ListNode l1, ListNode l2)
    {
        if(l1 == null && l2 == null) { return new ListNode(); }

        int n1, n2, cf = 0, val=0;
        bool isCF = false;
        List<int> outList = new List<int>();

        ListNode l1next = l1, l2next = l2, outnext = null;
        while (!( (l1next == null) && (l2next == null))) {

            n1 = l1next == null ? 0 : l1next.val;
            n2 = l2next == null ? 0 : l2next.val;
            
            val = (n1 + n2 + cf) % 10; if( (n1+n2+cf) >=10) { isCF = true; }
            cf = (n1 + n2 + cf) / 10;

            outList.Add(val);

            l1next = l1next == null ? null : l1next.next; 
            l2next = l2next == null ? null: l2next.next;
        }

        if(isCF && cf !=0) { outList.Add(cf); }

        int count1 = outList.Count();
        ListNode prev1Node = null;
        ListNode output;

        for (int i = count1 - 1; i >= 0; i--)
        {
            ListNode newNode = new ListNode(outList[i], prev1Node);
            prev1Node = newNode;
        }
        output = prev1Node;

        return output;
    }
}
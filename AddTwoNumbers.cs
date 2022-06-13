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

        List<int> outList = new List<int>(); string str = string.Empty;
        
        int n1 = 0, n2 = 0, k = 1, output = 0; int temp = 0;

        //for (int i = l1.Count -1; i >=0 ; i--) {
        //    n1 += l1[i] * Convert.ToInt32(Math.Pow(10, i));
        //}

        //for (int j = l2.Count - 1; j >= 0; j--) {
        //    n2 += l2[j] * Convert.ToInt32(Math.Pow(10, j));
        //}

        output = n1 + n2;

        temp = output;
        while (output > 0)
        {
            temp = output % 10;
            outList.Add(temp);
            output = output / 10;
        }        

        return null;
    }
}
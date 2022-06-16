// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int[] nums = { 2, 7, 11, 15 };
// int[] nums = {-3, 4, 3, 90};
// int target = 0;
// TwoSum.Operation1(nums, target);

//int output = LongestSubstring.Operation1("aab");

/*
int res14 = StringToIntegerMyAtoi.Approach2("20000000000000000000");
int res15 = StringToIntegerMyAtoi.Approach2(" ");
int res1 = StringToIntegerMyAtoi.Approach2("-91283472332");
int res2 = StringToIntegerMyAtoi.Approach2("   -42");
int res3 = StringToIntegerMyAtoi.Approach2("4193 with words");
int res4 = StringToIntegerMyAtoi.Approach2("");
int res5 = StringToIntegerMyAtoi.Approach2("   -0012a42");
int res6 = StringToIntegerMyAtoi.Approach2("3.14159");
int res7 = StringToIntegerMyAtoi.Approach2("words and 987");
int res8 = StringToIntegerMyAtoi.Approach2("+-12");
int res9 = StringToIntegerMyAtoi.Approach2("-+12");
int res10 = StringToIntegerMyAtoi.Approach2("+1");

int res11 = StringToIntegerMyAtoi.Approach2("21474836460"); //out: 2147483647
int res12 = StringToIntegerMyAtoi.Approach2("-91283472332"); //out: -2147483648
int res13 = StringToIntegerMyAtoi.Approach2("21474836460"); //out: 2147483647
*/

int[] arr1 = new int[] { 9, 9, 9, 9, 9, 9, 9 };
int[] arr2 = new int[] { 9, 9, 9, 9 };
int count1 = arr1.Length;
int count2 = arr2.Length;


AddTwoNumbers.ListNode prev1Node = null;
AddTwoNumbers.ListNode l1;

for (int i = count1-1; i >= 0 ; i--)
{
    AddTwoNumbers.ListNode newNode = new AddTwoNumbers.ListNode(arr1[i], prev1Node);
    prev1Node = newNode;
}
l1 = prev1Node;


AddTwoNumbers.ListNode prev2Node = null;
AddTwoNumbers.ListNode l2;

for (int i = count2 - 1; i >= 0; i--)
{
    AddTwoNumbers.ListNode newNode = new AddTwoNumbers.ListNode(arr2[i], prev2Node);
    prev2Node = newNode;
}
l2 = prev2Node;


AddTwoNumbers.ListNode res =  AddTwoNumbers.Operation1(l1, l2);

Console.WriteLine("done");
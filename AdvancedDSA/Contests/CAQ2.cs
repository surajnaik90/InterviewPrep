/*
Given an integer array A of size N.

You have to find the product of the three largest integers in array A from range 1 to i, where i goes from 1 to N.

Return an array B where B[i] is the product of the largest 3 integers in range 1 to i in array A. 
If i < 3, then the integer at index i in B should be -1.

Problem Constraints
1 <= N <= 105
0 <= A[i] <= 103

Input Format
First and only argument is an integer array A.

Output Format
Return an integer array B. B[i] denotes the product of the largest 3 integers in range 1 to i in array A.

Example Input
Input 1:

 A = [1, 2, 3, 4, 5]
Input 2:

 A = [10, 2, 13, 4]


Example Output
Output 1:

 [-1, -1, 6, 24, 60]
Output 2:

 [-1, -1, 260, 520]


Example Explanation
Explanation 1:

 For i = 1, ans = -1
 For i = 2, ans = -1
 For i = 3, ans = 1 * 2 * 3 = 6
 For i = 4, ans = 2 * 3 * 4 = 24
 For i = 5, ans = 3 * 4 * 5 = 60

 So, the output is [-1, -1, 6, 24, 60].
 
Explanation 2:

 For i = 1, ans = -1
 For i = 2, ans = -1
 For i = 3, ans = 10 * 2 * 13 = 260
 For i = 4, ans = 10 * 13 * 4 = 520

 So, the output is [-1, -1, 260, 520].
 */


//https://github.com/dotnet/runtime/blob/main/src/libraries/System.Collections/src/System/Collections/Generic/PriorityQueue.cs
//https://visualstudiomagazine.com/Articles/2012/11/01/Priority-Queues-with-C.aspx?Page=2

using System.Collections.Generic;

public static class CAQ2
{

    public static int solve(int A, int B)
    {
        int[] bitArray = new int[30];


        for (int i = 0; i < 30; i++) {

            if((A & (1<<i)) > 0) {
                bitArray[i] = 1;
            }
        }

        int count = B;
        int[] newBitArray = new int[30];
        for (int i = bitArray.Count() - 1; i >= 0; i--) {

            if (bitArray[i] == 1 && count > 0) {

                newBitArray[i] = 1;

                count--;
            }
            else {
                if((i+1) <= count) {
                    newBitArray[i] = 1;
                }
            }
        }

        int number = 0;
        for (int i = 0; i < 30; i++) {

            if (newBitArray[i] == 1) {
                number += (int)(Math.Pow(2, i));
            }
        }

        return number;
    }
}
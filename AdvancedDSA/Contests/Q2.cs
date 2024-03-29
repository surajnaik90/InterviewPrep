﻿/*
Given an integer, A. Find and Return first positive A integers in ascending order containing only digits 1, 2, and 3.

NOTE: All the A integers will fit in 32-bit integers.

Problem Constraints
1 <= A <= 29500

Input Format
The only argument given is integer A.

Output Format
Return an integer array denoting the first positive A integers in ascending order containing only digits 1, 2 and 3.

Example Input
Input 1:

 A = 3
Input 2:

 A = 7

Example Output
Output 1:

 [1, 2, 3]
Output 2:

 [1, 2, 3, 11, 12, 13, 21]

Example Explanation
Explanation 1:

 Output denotes the first 3 integers that contains only digits 1, 2 and 3.
Explanation 2:

 Output denotes the first 3 integers that contains only digits 1, 2 and 3.
 */

using System.Text;

public static class Q2
{
    public static int solve(List<int> A)
    {
        int N = A.Count, max1 = int.MinValue, max2 = 0;

        //First find the max of the array
        for (int i = 0; i < N; i++) {
            max1 = Math.Max(max1, A[i]);
            max2 = max2 | A[i];
        }

        return max1 + max2;
    }
}
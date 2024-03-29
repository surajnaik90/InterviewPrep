﻿/*
Given an array, A of integers of size N. Find the maximum value of j - i such that A[i] <= A[j].

Problem Constraints
1 <= N <= 105

-109 <= A[i] <= 109

Input Format
First argument is an integer array A of size N.

Output Format
Return an integer denoting the maximum value of j - i.

Example Input
Input 1:

A = [3, 5, 4, 2]

Example Output
Output 1:

2

Example Explanation
Explanation 1:

For A[0] = 3 and A[2] = 4, the ans is (2 - 0) = 2. 
 */

public static class MaxDistance
{
    public static int solve(List<int> A)
    {
        int maxDistance = 0, N = A.Count;

        int i = 0;
        for (int j = N-1; j >= i; j--) {

            if (A[i] <= A[j]) {
                maxDistance = Math.Max(maxDistance, j-i);
                j = N; i++;
            }
        }

        return maxDistance;
    }
}
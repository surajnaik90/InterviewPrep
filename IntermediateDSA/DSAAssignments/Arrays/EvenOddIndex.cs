﻿/*
Given an array, arr[] of size N, the task is to find the count of array indices such that removing an element 
from these indices makes the sum of even-indexed and odd-indexed array elements equal.

Problem Constraints
1 <= n <= 105
-105 <= A[i] <= 105

Input Format
First argument contains an array A of integers of size N

Output Format
Return the count of array indices such that removing an element from these indices makes the sum of 
even-indexed and odd-indexed array elements equal.

Example Input
Input 1:
A=[2, 1, 6, 4]
Input 2:

A=[1, 1, 1]

Example Output
Output 1:
1
Output 2:
3

Example Explanation
Explanation 1:
Removing arr[1] from the array modifies arr[] to { 2, 6, 4 } such that, arr[0] + arr[2] = arr[1]. 
Therefore, the required output is 1. 
Explanation 2:

Removing arr[0] from the given array modifies arr[] to { 1, 1 } such that arr[0] = arr[1] 
Removing arr[1] from the given array modifies arr[] to { 1, 1 } such that arr[0] = arr[1] 
Removing arr[2] from the given array modifies arr[] to { 1, 1 } such that arr[0] = arr[1] 
Therefore, the required output is 3.
 */

public static class EvenOddIndex
{
    public static int Operation1(List<int> A)
    {
        int output = 0, N=A.Count;
        int[] prefixEvenSum = new int[N]; int[] prefixOddSum = new int[N];
        int evenIndexedSum, oddIndexedSum, deltaEven, deltaOdd;

        //Build Prefix Even Sum & Prefix Odd Sum array
        prefixEvenSum[0] = A[0]; prefixOddSum[0] = 0;
        for (int i = 1; i < N; i++){

            if (i % 2 == 0) {
                prefixEvenSum[i] = prefixEvenSum[i - 1] + A[i];
                prefixOddSum[i] = prefixOddSum[i - 1];
            }
            else {
                prefixEvenSum[i] = prefixEvenSum[i - 1];
                prefixOddSum[i] = prefixOddSum[i - 1] + A[i];
            }
        }

        //Calculate count of indices when removed the even sum will equal to odd sum.
        for (int i = 0; i < N; i++)
        {
            //Remove ith element & check for equality
            if(i==0) { 
                evenIndexedSum = 0;
                oddIndexedSum = prefixOddSum[0];
            }
            else {
                evenIndexedSum = prefixEvenSum[i - 1];
                oddIndexedSum = prefixOddSum[i - 1];
            }

            deltaEven = prefixOddSum[N - 1] - prefixOddSum[i];
            deltaOdd = prefixEvenSum[N-1] - prefixEvenSum[i];

            evenIndexedSum += deltaEven; oddIndexedSum += deltaOdd;

            if (evenIndexedSum == oddIndexedSum) {
                output++;
            }
        }

        return output;
    }
}
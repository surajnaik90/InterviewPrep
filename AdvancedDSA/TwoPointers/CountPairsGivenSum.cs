﻿/*
Given a sorted array of distinct integers A and an integer B, 
find and return how many pair of integers ( A[i], A[j] ) such that i != j have sum equal to B.

Input Format

The first argument given is the integer array A.
The second argument given is integer B.
Output Format

Return the number of pairs for which sum is equal to B.
Constraints

1 <= length of the array <= 100000
1 <= A[i] <= 10^9 
1 <= B <= 10^9
For Example

Input 1:
    A = [1, 2, 3, 4, 5]
    B = 5
Output 1:
    2

Input 2:
    A = [5, 10, 20, 100, 105]
    B = 110
Output 2:
    2
 */

public static class CountPairsGivenSum
{
    public static int solve(List<int> A, int B)
    {
        int pairsCount = 0, N = A.Count, left = 0, right = N-1;
        long sum = 0, b = B;

        while (left <= right) {

            sum = (long)(A[left] + A[right]);

            if (sum > b) {
                right--;
            }
            else if ((sum == b) && (left!=right)) {
                pairsCount++; left++; right--;
            }
            else {
                left++;
            }
        }

        return pairsCount;
    }
}
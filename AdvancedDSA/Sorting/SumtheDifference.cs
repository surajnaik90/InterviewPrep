﻿/*
Given an integer array, A of size N.
You have to find all possible non-empty subsequences of the array of numbers and then, for each subsequence, 
find the difference between the largest and smallest numbers in that subsequence. Then add up all the differences to get the number.

As the number may be large, output the number modulo 1e9 + 7 (1000000007).

NOTE: Subsequence can be non-contiguous.

Problem Constraints
1 <= N <= 10000

1<= A[i] <=1000

Input Format
First argument is an integer array A.

Output Format
Return an integer denoting the output.

Example Input
Input 1:

A = [1, 2] 
Input 2:

A = [1]

Example Output
Output 1:

 1 
Output 2:

 0

Example Explanation
Explanation 1:

All possible non-empty subsets are:
[1]    largest-smallest = 1 - 1 = 0
[2]    largest-smallest = 2 - 2 = 0
[1 2]  largest-smallest = 2 - 1 = 1
Sum of the differences = 0 + 0 + 1 = 1
So, the resultant number is 1 
Explanation 2:

 Only 1 subsequence of 1 element is formed.
 */

using System.Linq;

public static class SumtheDifference
{
    //Won't work if N is in handreads. If N is 800, then 2^800 would be big number,
    //so, we'll have to find the optimal way.
    public static int solve(List<int> A)
    {
        List<List<int>> subsequences = new List<List<int>>();
        int N = A.Count, sum=0;
        int mod = (int)((Math.Pow(10, 9)) + 7);

        A.Sort();

        subsequences = Subsequences.solve(A);

        for (int i = 1; i < subsequences.Count; i++) {

            if (subsequences[i].Count == 1) {
                continue;
            }

            int first = subsequences[i].ElementAt(0);
            int n = subsequences[i].Count, last = subsequences[i].ElementAt(n-1);

            sum = ( (sum%mod) +  ((Math.Abs(last - first))%mod))%mod;
        }

        return sum;
    }
}
/*
Given an array of integers A.

value of a array = max(array) - min(array).

Calculate and return the sum of values of all possible subarrays of A modulo 109+7.

Problem Constraints
1 <= |A| <= 100000

1 <= A[i] <= 1000000

Input Format
The first and only argument given is the integer array A.

Output Format
Return the sum of values of all possible subarrays of A modulo 109+7.

Example Input
Input 1:

 A = [1]
Input 2:

 A = [4, 7, 3, 8]

Example Output
Output 1:

 0
Output 2:

 26

Example Explanation
Explanation 1:

Only 1 subarray exists. Its value is 0.
Explanation 2:

value ( [4] ) = 4 - 4 = 0
value ( [7] ) = 7 - 7 = 0
value ( [3] ) = 3 - 3 = 0
value ( [8] ) = 8 - 8 = 0
value ( [4, 7] ) = 7 - 4 = 3
value ( [7, 3] ) = 7 - 3 = 4
value ( [3, 8] ) = 8 - 3 = 5
value ( [4, 7, 3] ) = 7 - 3 = 4
value ( [7, 3, 8] ) = 8 - 3 = 5
value ( [4, 7, 3, 8] ) = 8 - 3 = 5
sum of values % 10^9+7 = 26
 */

using System.Text;

public static class MaxMinStack
{
    public static int solve(List<int> A)
    {
        int mod = (int)(Math.Pow(10, 9) + 7);

        int ans = 0;

        //Calculate prefix max
        int[] prefixMax = new int[A.Count];
        prefixMax[0] = A[0];
        for (int i = 1; i < A.Count; i++) {

            prefixMax[i] = Math.Max(prefixMax[i - 1], A[i]);
        }

        //Calculate prefix min
        int[] prefixMin = new int[A.Count];
        prefixMin[0] = A[0];
        for (int i = 1; i < A.Count; i++) {
            prefixMin[i] = Math.Min(prefixMin[i - 1], A[i]);
        }

        //Calculate the result
        for (int i = 1; i < prefixMax.Length; i++) {

            ans = ans + ((Math.Abs(prefixMax[i] - prefixMin[i])) * i);

            ans = ans % mod;
        }

        return ans % mod;
    }
}
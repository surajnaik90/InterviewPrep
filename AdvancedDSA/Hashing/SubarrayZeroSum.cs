/*
Given an array of integers A, find and return whether the given array contains a non-empty 
subarray with a sum equal to 0.

If the given array contains a sub-array with sum zero return 1, else return 0.

Problem Constraints
1 <= |A| <= 100000

-10^9 <= A[i] <= 10^9

Input Format
The only argument given is the integer array A.

Output Format
Return whether the given array contains a subarray with a sum equal to 0.

Example Input
Input 1:

 A = [1, 2, 3, 4, 5]
Input 2:

 A = [-1, 1]

Example Output
Output 1:

 0
Output 2:

 1

Example Explanation
Explanation 1:

 No subarray has sum 0.
Explanation 2:

 The array has sum 0. */

public static class SubarrayZeroSum
{
    public static int solve(List<int> A)
    {
        Dictionary<long, int> map = new Dictionary<long, int>();

        long[] prefixSum = new long[A.Count];
        prefixSum[0] = A[0]; map.Add(0, 1);
        map.Add(prefixSum[0], 1);

        for (int i = 1; i < A.Count; i++) {

            prefixSum[i] = prefixSum[i - 1] + (long)A[i];

            if (map.ContainsKey(prefixSum[i])) {
                return 1;
            }
            else {
                map.Add(prefixSum[i], 1);
            }
        }

        return 0;
    }
}
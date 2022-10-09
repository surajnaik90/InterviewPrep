/*
Given an array A of size N, Groot wants you to pick 2 indices i and j such that

1 <= i, j <= N
A[i] % A[j] is maximum among all possible pairs of (i, j).
Help Groot in finding the maximum value of A[i] % A[j] for some i, j.

Problem Constraints
1 <= N <= 100000
0 <= A[i] <= 100000

Input Format
First and only argument in an integer array A.

Output Format
Return an integer denoting the maximum value of A[i] % A[j] for any valid i, j.

Example Input
Input 1:

 A = [1, 2, 44, 3]
Input 2:

 A = [2, 6, 4]

Example Output
Output 1:

 3
Output 2:

 4

Example Explanation
Explanation 1:

 For i = 3, j = 2  A[i] % A[j] = 3 % 44 = 3.
 No pair exists which has more value than 3.
Explanation 2:

 For i = 2, j = 1  A[i] % A[j] = 4 % 6 = 4.
 */

public static class MaxModPairs
{
    //Time limit exceeds.
    public static int solve(List<int> A)
    {
        int maxMod = int.MinValue, N = A.Count;

        for (int i = 0; i < N-1; i++) {

            for (int j = i+1; j < N; j++) {

                if (A[j] != 0) {
                    maxMod = Math.Max(maxMod, A[i] % A[j]);
                }

                if (A[i] != 0) {
                    maxMod = Math.Max(maxMod, A[j] % A[i]);
                }
            }
        }

        return maxMod;
    }

    //Optimal approach
    public static int optimallySolve(List<int> A)
    {
        int maxMod = 0, N = A.Count;

        A.Sort();

        int prev = A[N - 1];
        for (int i = N-2; i >= 0; i--) {

            if (A[i] != prev) {

                maxMod = Math.Max(maxMod, A[i] % prev);
                return maxMod;
            }
        }

        return maxMod;
    }
}
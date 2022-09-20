/*
Given an integer array A of size N. You have to delete one element such that the
GCD(Greatest common divisor) of the remaining array is maximum.

Find the maximum value of GCD.

Problem Constraints

2 <= N <= 105
1 <= A[i] <= 109

Input Format

First argument is an integer array A.

Output Format

Return an integer denoting the maximum value of GCD.

Example Input

Input 1:

 A = [12, 15, 18]
Input 2:

 A = [5, 15, 30]


Example Output

Output 1:

 6
Output 2:

 15


Example Explanation

Explanation 1:

 
 If you delete 12, gcd will be 3.
 If you delete 15, gcd will be 6.
 If you delete 18, gcd will 3.
 Maximum vallue of gcd is 6.
Explanation 2:

 If you delete 5, gcd will be 15.
 If you delete 15, gcd will be 5.
 If you delete 30, gcd will be 5.
 */

public static class DeleteOne
{
    public static int solve(List<int> A)
    {
        int output = int.MinValue, N = A.Count;

        int[] prefixGCD = new int[N];
        int[] suffixGCD = new int[N];

        prefixGCD[0] = A[0];
        for (int i = 1; i < N; i++) {
            prefixGCD[i] = GCD.solve(prefixGCD[i-1], A[i]);
        }


        suffixGCD[N - 1] = A[N - 1];
        for (int j = N-2; j >=0; j--) {
            suffixGCD[j] = GCD.solve(suffixGCD[j + 1], A[j]);
        }

        for (int i = 0; i < N; i++) {

            if (i == 0) {
                output = Math.Max(output, suffixGCD[i + 1]);
            }
            else if (i == N - 1) {
                output = Math.Max(output, prefixGCD[i-1]);
            }
            else {
                int gcd = GCD.solve(prefixGCD[i - 1], suffixGCD[i + 1]);

                output = Math.Max(output, gcd);
            }
        }

        return output;
    }
}
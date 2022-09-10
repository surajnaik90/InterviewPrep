/*
Given an array of integers A and an integer B, find and return the minimum number of swaps required
to bring all the numbers less than or equal to B together.

Note: It is possible to swap any two elements, not necessarily consecutive.

Problem Constraints

1 <= length of the array <= 100000
-109 <= A[i], B <= 109

Input Format

The first argument given is the integer array A.
The second argument given is the integer B.

Output Format

Return the minimum number of swaps.

Example Input

Input 1:

 A = [1, 12, 10, 3, 14, 10, 5]
 B = 8
Input 2:

 A = [5, 17, 100, 11]
 B = 20


Example Output

Output 1:

 2
Output 2:

 1


Example Explanation

Explanation 1:

 A = [1, 12, 10, 3, 14, 10, 5]
 After swapping  12 and 3, A => [1, 3, 10, 12, 14, 10, 5].
 After swapping  the first occurence of 10 and 5, A => [1, 3, 5, 12, 14, 10, 10].
 Now, all elements less than or equal to 8 are together.
Explanation 2:

 A = [5, 17, 100, 11]
 After swapping 100 and 11, A => [5, 17, 11, 100].
 Now, all elements less than or equal to 20 are together.
 */

public static class MinimumSwaps
{

    //Time Limit Exceeds
    public static int solve(List<int> A, int B)
    {
        int L = 0, N = A.Count, output = int.MaxValue;

        for (int j = 0; j < N; j++) {

            if (A[j] <= B) { 
                L++;
            }
            else {
                A[j] = int.MaxValue;
            }
        }

        if (L == 0 || L == 1) { 
            return 0;
        }

        for (int i = 0; i <= N-L; i++) {

            int k = i, m = i + L - 1, swap = 0;

            while(k <= m) {

                if (A[k] == int.MaxValue) {
                    swap++;
                }
                k++;
            }

            output = Math.Min(output, swap);
        }

        return output;
    }


    //Solved using Sliding Window technique with O(N) space complexity
    public static int solve2(List<int> A, int B)
    {
        int L = 0, N = A.Count, output = int.MaxValue;

        int[] S = new int[N];
        for (int j = 0; j < N; j++) {

            if (A[j] <= B) {
                L++; S[j] = 0;
            }
            else {
                S[j] = 1;
            }
        }

        if (L == 0 || L == 1) {
            return 0;
        }

        int sum = 0;
        for (int k = 0; k < L; k++) {
            sum += S[k];
        }


        for (int i = 1; i <= N - L; i++) {

            sum -= S[i - 1];

            sum += S[i + L - 1];

            output = Math.Min(output, sum);
        }

        if (output == int.MaxValue) { return 0; }

        return output;
    }
}
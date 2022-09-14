/*
Given an array of integers, every element appears thrice except for one, which occurs once.

Find that element that does not appear thrice.

NOTE: Your algorithm should have a linear runtime complexity.

Could you implement it without using extra memory?

Problem Constraints
2 <= A <= 5*106

0 <= A <= INTMAX

Input Format
First and only argument of input contains an integer array A.

Output Format
Return a single integer.

Example Input
Input 1:

 A = [1, 2, 4, 3, 3, 2, 2, 3, 1, 1]
Input 2:

 A = [0, 0, 0, 1]

Example Output
Output 1:

 4
Output 2:

 1


Example Explanation
Explanation 1:

 4 occurs exactly once in Input 1.
 1 occurs exactly once in Input 2.

 */

public static class SingleNumberII
{
    public static int solve(List<int> A)
    {
        int N = A.Count, output = 0;

        int i = 0, k;
        while (i <= 31) {

            int sum = 0; k = 1 << i;

            for (int j = 0; j < N; j++) {
                if ((A[j]&k) == k) {
                    sum += 1;
                }
            }
            if (sum % 3 != 0) {
                output = output | k;
            }
            i++;
        }

        return output;
    }
}
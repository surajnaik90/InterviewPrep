/*
Given a number A. Return square root of the number if it is perfect square otherwise return -1.

1 <= A <= 10^8

Input Format

First argument is an integer A.

Output Format

Return an integer which is the square root of A if A is perfect square otherwise return -1.

Example Input

Input 1:

A = 4
Input 2:

A = 1001


Example Output

Output 1:

2
Output 2:

-1
 */

public static class SquareRoot
{
    public static int Operation1(int A)
    {
        int output = -1;

        long i = 1, j = A, count = A / 2, k = 1;
        long mid = (i + j) / 2;

        while (count != 1)
        {
            if (A < (mid * mid)) {
                j = mid;
            }

            else if (A > (mid * mid)) {
                i = mid;
            }
            else
            {
                return Convert.ToInt32(mid);
            }

            mid = (i + j) / 2;
            count = A / Convert.ToInt32((Math.Pow(2, k++)));
        }

        if (A == (mid * mid)) { return Convert.ToInt32(mid); }

        return output;
    }
}
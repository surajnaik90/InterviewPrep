/*
Given two integers A and B. Find the value of A-1 mod B where B is a prime number and gcd(A, B) = 1.

A-1 mod B is also known as modular multiplicative inverse of A under modulo B.

Problem Constraints
1 <= A <= 109
1<= B <= 109
B is a prime number

Input Format
First argument is an integer A.
Second argument is an integer B.

Output Format
Return an integer denoting the modulor inverse

Example Input
Input 1:

 A = 3
 B = 5
Input 2:

 A = 6
 B = 23


Example Output
Output 1:

 2
Output 2:

 4

Example Explanation
Explanation 1:

 Let's say A-1 mod B = X, then (A * X) % B = 1.
 3 * 2 = 6, 6 % 5 = 1.
Explanation 2:

 Similarly, (6 * 4) % 23 = 1.

 */

public static class PrimeModuloInverse
{
    //Time Limit Exceeded.
    public static int solve(int A, int B)
    {
        int output = 1;

        long a = (long)A, b = (long)B, x;

        for (x = 1; x < b; x++) {

            long res = (a * x)%b;

            if (res == 1) {
                return (int)(x);
            }
        }

        return output;
    }

    //Optimal approach
    public static int solve2(int A, int B)
    {
        int i = 1;

        for (int m = A; m < int.MaxValue; m+=A) {

            if (m % B == 1) {

                return i;
            }

            i++;
        }

        return i;
    }
}
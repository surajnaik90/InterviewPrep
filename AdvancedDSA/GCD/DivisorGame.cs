/*
Scooby has 3 three integers A, B, and C.

Scooby calls a positive integer special if it is divisible by B and it is divisible by C. 
You need to tell the number of special integers less than or equal to A.

Problem Constraints
1 <= A, B, C <= 109

Input Format
First argument is a positive integer A
Second argument is a positive integer B
Third argument is a positive integer C

Output Format
One integer corresponding to the number of special integers less than or equal to A.

Example Input
Input 1:

 A = 12
 B = 3
 C = 2
Input 2:

 A = 6
 B = 1
 C = 4


Example Output
Output 1:

 2
Output 2:

 1

Example Explanation
Explanation 1:

 The two integers divisible by 2 and 3 and less than or equal to 12 are 6,12.
Explanation 2:

 Only 4 is a positive integer less than equal to 6 which is divisible by 1 and 4.

 */

public static class DivisorGame
{

    //Time Limit Exceeds
    public static int solve(int A, int B, int C)
    {
        int output = 0;

        for (int i = 1; i <= A; i++) {

            if(i%B==0 && i % C == 0) {
                output++;
            }
        }

        return output;
    }

    //Optimal solution
    public static int solve2(int A, int B, int C)
    {
        long res = B * C;

        long gcd = DivisorGame.gcd(B, C);

        long lcm = res / gcd;

        long a = Convert.ToInt64(A);

        long ans = a / lcm;

        return Convert.ToInt32(ans);
    }

    public static int gcd(int m, int n)
    {
        int a, b;

        if (m <= n)
        {
            a = m;
            b = n;
        }
        else
        {
            b = m;
            a = n;
        }

        if (b == 0)
        {
            return a;
        }
        else if (a == 0)
        {
            return b;
        }
        return gcd(a, b % a);
    }

}
/*
Given three integers A, B, and C, where A represents n, B represents r, and C 
represents p and p is a prime number greater than equal to n, find and return 
the value of nCr % p where nCr % p = (n! / ((n-r)! * r!)) % p.

x! means factorial of x i.e. x! = 1 * 2 * 3... * x.

NOTE: For this problem, we are considering 1 as a prime.

Problem Constraints
1 <= A <= 106
1 <= B <= A
A <= C <= 109+7

Input Format
The first argument given is the integer A ( = n).
The second argument given is the integer B ( = r).
The third argument given is the integer C ( = p).

Output Format
Return the value of nCr % p.

Example Input
Input 1:

 A = 5
 B = 2
 C = 13
Input 2:

 A = 6
 B = 2
 C = 13


Example Output
Output 1:

 10
Output 2:

 2

Example Explanation
Explanation 1:

 nCr( n=5 and r=2) = 10.
 p=13. Therefore, nCr%p = 10.
 */

public static class ncrmodp
{
    public static int solve(int A, int B, int C)
    {
        int[] factorial = new int[A+1];
        long mod = Convert.ToInt64(C);

        factorial[0] = 1;
        for (int i = 1; i <=A; i++) {

            long nminusonefactorial = Convert.ToInt64(factorial[i - 1]);
            long currentElement = Convert.ToInt64(i);

            factorial[i] = (int)((nminusonefactorial * currentElement)%mod);
        }

        int nfactorial = factorial[A];
        int nminusrfactorial = factorial[A - B];
        int rfactorial = factorial[B];

        int inversenminusrfactorial = moduloinverse(nminusrfactorial, C);
        int inverserfactorial = moduloinverse(rfactorial, C);


        int ans = (int)((Convert.ToInt64(nfactorial) * Convert.ToInt64(inversenminusrfactorial)) % mod);

        ans = (int)((Convert.ToInt64(ans) * (Convert.ToInt64(inverserfactorial)) % mod));

        return ans;
    }

    public static int moduloinverse(int A, int C)
    {
        return PowerFunction.pow(A, C - 2, C);
    }
}
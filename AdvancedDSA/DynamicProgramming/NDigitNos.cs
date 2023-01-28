/*
Find out the number of A digit positive numbers, 
whose digits on being added equals to a given number B.

Note that a valid number starts from digits 1-9 except the number 0 itself. 
i.e. leading zeroes are not allowed.

Since the answer can be large, output answer modulo 1000000007

Problem Constraints
1 <= A <= 1000

1 <= B <= 10000

Input Format
First argument is the integer A

Second argument is the integer B

Output Format
Return a single integer, the answer to the problem

Example Input
Input 1:

 A = 2
 B = 4
Input 2:

 A = 1
 B = 3

Example Output
Output 1:

 4
Output 2:

 1

Example Explanation
Explanation 1:

 Valid numbers are {22, 31, 13, 40}
 Hence output 4.
Explanation 2:

 Only valid number is 3
 */

using System.Collections;
using System.Net.Http.Headers;

public static class NdigitNumbers
{
    public static int solve(int A, int B)
    {
        int res, mod = (int)((Math.Pow(10,9)) + 7);

        res = ways(0, A, B, mod);

        return res;
    }

    public static int ways(int sum, int A, int B, int mod)
    {
        long ans = 0;

        if (A == 0 && sum == B) {
            return 1;
        }

        if(A == 0 && (sum < B || sum > B)) {
            return 0;
        }

        if(sum > B) { return 0; }

        for (int i = 0; i <= 9; i++) {

            sum = sum + i;

            if (sum == 0) { continue; }

            A--;

            long res = ans;

            ans += ways(sum, A, B, mod);

            if(ans == (res + 1)) {
                break;
            }

            A++; sum = sum - i;
        }

        return Convert.ToInt32(ans % mod);
    }
}
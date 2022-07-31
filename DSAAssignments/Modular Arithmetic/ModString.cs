﻿/*
ts
1 <= A.length() <= 105
0 <= Ai <= 9
1 <= B <= 109

Input Format
The first argument is a string A.
The second argument is an integer B.

Output Format
Return a single integer denoting the value of A % B.

Example Input
Input 1:
A = "143"
B = 2
Input 2:

A = "43535321"
B = 47


Example Output
Output 1:
1
Output 2:

20

Example Explanation
Explanation 1:
143 is an odd number so 143 % 2 = 1.
Explanation 2:

43535321 % 47 = 20
 */

public static class ModString
{
    public static int Operation1(string A, int B)
    {
        int N=A.Length, output = Convert.ToInt32(A[N-1]);

        for (int i = N-1; i >=0; i--) {
            output %= B;
        }

        return output;
    }
}
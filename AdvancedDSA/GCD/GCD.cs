﻿/*
Given 2 non-negative integers A and B, find gcd(A, B)

GCD of 2 integers A and B is defined as the greatest integer 'g' such that 
'g' is a divisor of both A and B. Both A and B fit in a 32 bit signed integer.

Note: DO NOT USE LIBRARY FUNCTIONS.

Problem Constraints
0 <= A, B <= 109

Input Format
First argument is an integer A.
Second argument is an integer B.

Output Format
Return an integer denoting the gcd(A, B).

Example Input
Input 1:

A = 4
B = 6
Input 2:

A = 6
B = 7


Example Output
Output 1:

 2
Output 2:

 1

Example Explanation
Explanation 1:

 2 divides both 4 and 6
Explanation 2:

 1 divides both 6 and 7
 */

public static class GCD
{
    public static int solve(int A, int B)
    {
        return gcd(A, B);
    }

    public static int gcd(int m, int n)
    {
        int a, b;

        if (m <= n) { 
            a = m;
            b = n;
        }
        else {
            b = m;
            a = n;
        }

        if(b== 0) { 
            return a ;
        }
        else if(a==0) {
            return b;
        }
        return gcd(a, b % a);
    }
}
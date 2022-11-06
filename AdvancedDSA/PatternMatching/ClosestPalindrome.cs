/*
Groot has a profound love for palindrome which is why he keeps fooling around with strings.
A palindrome string is one that reads the same backward as well as forward.

Given a string A of size N consisting of lowercase alphabets, 
he wants to know if it is possible to make the given string a palindrome by changing exactly one of its character.

Problem Constraints
1 <= N <= 105

Input Format
The first and only argument is a string A.

Output Format
Return the string YES if it is possible to make the given string a palindrome by changing exactly 1 character. 
Else, it should return the string NO.

Example Input
Input 1:

 A = "abbba"
Input 2:

 A = "adaddb"

Example Output
Output 1:

 "YES"
Output 2:

 "NO"

Example Explanation
Explanation 1:

 We can change the character at index 3(1-based) to any other character. The string will be palindromic.
Explanation 2:

 To make the string palindromic we need to change 2 characters. 
 */

using System.Numerics;

public static class ClosestPalindrome
{
    public static string solve(string A)
    {
        string ans = "NO";

        int N = A.Length, j = N - 1; long mod = ((long)(Math.Pow(10, 9) + 7));

        //Calculate hash values of a given string and its reversed string
        long hash = 0, reversehash = 0;
        for (int i = 0; i < N; i++) {

            hash += (((long)(pow(26, j--, mod))) * ((long)A[i]));
            hash %= mod;

            reversehash += (((long)(pow(26, i, mod))) * ((long)A[i]));
            reversehash %= mod;
        }

        int x = 0, y = N - 1;
        long newhash = hash, newreversehash = reversehash;
        while (x <= y) {

            if (A[x] == A[y]) {
                if (x == y) { ans = "YES"; }
                x++; y--;
                continue;
            }
            else {
                //Compute hash & reverse hash to check if we can replace 1 character

                newhash -= (((long)(pow(26, y, mod))) * ((long)A[x]));
                newhash += (((long)(pow(26, y, mod))) * ((long)A[y]));
                newhash %= mod;

                newreversehash -= (((long)(pow(26, x, mod))) * ((long)A[x]));
                newreversehash += (((long)(pow(26, x, mod))) * ((long)A[y]));
                newreversehash %= mod;

                if (newhash == newreversehash) {
                    return "YES";
                }
                else {
                    return "NO";
                }
            }
        }

        return ans;
    }


    public static int pow(int A, int B, long C)
    {
        if (A == 0 && B == 0) { return 0; }

        if (B == 0) { return 1; }

        int half = pow(A, B / 2, C);

        long ans = ((Convert.ToInt64(half) % Convert.ToInt64(C)) * (Convert.ToInt64(half) % Convert.ToInt64(C)) % C);

        if (B % 2 == 0) {

            if (ans < 0) { ans = Convert.ToInt64(C) + ans; }

            return (int)ans;
        }
        else {

            ans = ((ans * (Convert.ToInt64(A) % Convert.ToInt64(C))) % C);

            if (ans < 0) { ans = Convert.ToInt64(C) + ans; }

            return (int)ans;
        }
    }

    //Second approach - Using BigInteger in built of C#
    public static string solve2(string A)
    {
        string ans = "NO";

        int N = A.Length, j = N - 1; long mod = ((long)(Math.Pow(10, 9) + 7));

        //Calculate hash values of a given string and its reversed string
        long hash = 0, reversehash = 0;
        for (int i = 0; i < N; i++) {

            hash += (((long)(BigInteger.ModPow(26, j--,mod))) * ((long)A[i]));
            hash %= mod;

            reversehash += (((long)(BigInteger.ModPow(26, i, mod))) * ((long)A[i]));
            reversehash %= mod;
        }

        int x = 0, y = N - 1;
        long newhash = hash, newreversehash = reversehash;
        while (x <= y) {

            if (A[x] == A[y]) {
                if (x == y) { ans = "YES"; }
                x++; y--;
                continue;
            }
            else {
                //Compute hash & reverse hash to check if we can replace 1 character

                newhash -= (((long)(BigInteger.ModPow(26, y, mod))) * ((long)A[x]));
                newhash += (((long)(BigInteger.ModPow(26, y, mod))) * ((long)A[y]));
                newhash %= mod;

                newreversehash -= (((long)(BigInteger.ModPow(26, x, mod))) * ((long)A[x]));
                newreversehash += (((long)(BigInteger.ModPow(26, x, mod))) * ((long)A[y]));
                newreversehash %= mod;

                if (newhash == newreversehash) {
                    return "YES";
                }
                else {
                    return "NO";
                }
            }
        }

        return ans;
    }
}
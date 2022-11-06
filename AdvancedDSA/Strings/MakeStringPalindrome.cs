/*
Given a string A of size N consisting only of lowercase alphabets. 
The only operation allowed is to insert characters in the beginning of the string.

Find and return how many minimum characters are needed to be inserted to make the string a palindrome string.

Problem Constraints
1 <= N <= 106

Input Format
The only argument given is a string A.

Output Format
Return an integer denoting the minimum characters needed to be inserted in the beginning to make the string a palindrome string.

Example Input
Input 1:

 A = "abc"
Input 2:

 A = "bb"

Example Output
Output 1:

 2
Output 2:

 0

Example Explanation
Explanation 1:

 Insert 'b' at beginning, string becomes: "babc".
 Insert 'c' at beginning, string becomes: "cbabc".
Explanation 2:

 There is no need to insert any character at the beginning as the string is already a palindrome. 
 */

public static class MakeStringPalindrome
{
    //Using Rolling Hash technique
    public static int solve(string A)
    {
        int count = 0; long mod = ((long)(Math.Pow(10, 9) + 7));
        long hash = 0, reverseHash = 0; int N = A.Length;
        

        int j = N - 1;
        for (int i = 0; i < N; i++) {

            hash += (((long)(Math.Pow(26, j--))) * A[i]);
            hash %= mod;

            reverseHash += (((long)(Math.Pow(26, i))) * A[i]);
            reverseHash %= mod;
        }

        if (hash == reverseHash) {
            return 0;
        }

        long newHash = hash, newReverseHash = reverseHash; j = N;
        for (int i = 1; i < N; i++) {

            newHash = hash + ((((long)(Math.Pow(26, j++))) * (long)A[i]));
            newHash %= mod;
            hash = newHash;

            newReverseHash = ((long)(26 * reverseHash)) + ((long)A[i]);
            newReverseHash %= mod;
            reverseHash = newReverseHash;

            if(newHash == newReverseHash) {
                return count;
            }
            count++;
        }

        return count;
    }
}
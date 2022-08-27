/*
Given a string A of size N, find and return the longest palindromic substring in A.

Substring of string A is A[i...j] where 0 <= i <= j < len(A)

Palindrome string:
A string which reads the same backwards. More formally, A is palindrome if reverse(A) = A.

Incase of conflict, return the substring which occurs first ( with the least starting index).

Problem Constraints
1 <= N <= 6000

Input Format
First and only argument is a string A.

Output Format
Return a string denoting the longest palindromic substring of string A.

Example Input
A = "aaaabaaa"

Example Output
"aaabaaa"

Example Explanation
We can see that longest palindromic substring is of length 7 and the string is "aaabaaa".
 */

public static class LongestPalindromcString
{
    public static string Operation1(string A)
    {
        string longestSubstr; int N = A.Length, substrlength;

        //Check for Odd length substr
        int l, r, count=1; longestSubstr = A[0].ToString();
        for (int i = 1; i < N; i++) {

            l = i-1; r = i + 1;
            int len = 1;
            while(l>=0 && r <= N-1) {

                if (A[l] != A[r]) {
                    break;
                }
                len += 2; l--; r++;
            }

            substrlength = r - 1 - l;
            if (substrlength > count) {
                count = substrlength;
                longestSubstr = A.Substring(l + 1, substrlength);
            }
        }

        //Initialize substring for even length if last substring count is less than 2
        if(count < 2) {
            
            if(A.Length>=2) {

                if (A[0] == A[1]) {
                    count = 2;
                    longestSubstr = A.Substring(0, 2);
                }
            }
        }

        //Check for Even length substr
        for (int i = 1; i < N; i++)
        {
            l = i; r = i + 1;
            int len = 2;
                        
            while (l >= 0 && r <= N - 1) {

                if (A[l] != A[r]) {
                    break;
                }

                len += 2; l--; r++;
            }

            substrlength = r - 1 - l;
            if (substrlength > count) {
                count = substrlength;
                longestSubstr = A.Substring(l + 1, substrlength);
            }
        }

        return longestSubstr;
    }
}
﻿/*
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
    public static int Operation1(List<int> A)
    {
        int output = 0;

        for (int i = 0; i < A.Count; i++)
        {
            int digit = output % 2 == 0 ? A[i] : A[i] ^ 1;

            if (digit == 0)
            {
                output++;
            }
        }

        return output;
    }
}
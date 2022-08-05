﻿/*
Given a string A, you are asked to reverse the string and return the reversed string.

Problem Constraints
1 <= |A| <= 105

String A consist only of lowercase characters.

Input Format
First and only argument is a string A.

Output Format
Return a string denoting the reversed string.

Example Input
Input 1:

 A = "scaler"
Input 2:

 A = "academy"


Example Output
Output 1:

 "relacs"
Output 2:

 "ymedaca"

Example Explanation
Explanation 1:

 Reverse the given string.
 */

using System.Text;

// Please note: Using "+" operator to concatenate strings we hit TLE issues.
// Instead use StringBuilder to concatenate strings.
public static class SimpleReverse
{
    public static string Operation1(string A)
    {
        string str = A.Trim();

        StringBuilder ans = new StringBuilder(str.Length);
        for (int i = str.Length - 1; i >= 0; i--){
            ans.Append(str[i]);
        }

        return ans.ToString();
    }
}
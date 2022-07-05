/*
You have given a string A having Uppercase English letters.

You have to find how many times subsequence "AG" is there in the given string.

NOTE: Return the answer modulo 109 + 7 as the answer can be very large.

Problem Constraints
1 <= length(A) <= 105

Input Format
First and only argument is a string A.

Output Format
Return an integer denoting the answer.

Example Input
Input 1:

 A = "ABCGAG"
Input 2:

 A = "GAB"


Example Output
Output 1:

 3
Output 2:

 0

Example Explanation
Explanation 1:

 Subsequence "AG" is 3 times in given string 
Explanation 2:

 There is no subsequence "AG" in the given string.
 */

public static class SpecialSubsequenceAG
{
    public static int Operation1(string A)
    {
        int output = 0, count_g=0;

        for (int i = 0; i < A.Length; i++) {
            if (A[i]=='G') { count_g++; }
        }

        for (int j = 0; j < A.Length; j++)
        {
            if (A[j] == 'A')
            {
                output += count_g;
            }

            if (A[j] == 'G')
            {
                count_g--;
            }
        }

        return output%(Convert.ToInt32(Math.Pow(10,9))+7);
    }
}
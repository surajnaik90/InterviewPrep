/*
Write a recursive function that, given a string S, prints the characters of S in reverse order.

Problem Constraints
1 <= |s| <= 1000

Input Format
First line of input contains a string S.

Output Format
Print the character of the string S in reverse order.

Example Input
Input 1:

 scaleracademy
Input 2:

 cool

Example Output
Output 1:

 ymedacarelacs
Output 2:

 looc

Example Explanation
Explanation 1:

 Print the reverse of the string in a single line.
 */
public static class PrintReverseString
{
    public static void solve(string A)
    {
        int n = A.Length;

        if (A.Length == 1) { return; }
        
        solve(A.Substring(0,n-A.Length+1));

        Console.Write(A);
    }
}
/*
Find the number of occurrences of bob in string A consisting of lowercase English alphabets.

Problem Constraints
1 <= |A| <= 1000

Input Format
The first and only argument contains the string A, consisting of lowercase English alphabets.

Output Format
Return an integer containing the answer.

Example Input
Input 1:

  "abobc"
Input 2:

  "bobob"

Example Output
Output 1:

  1
Output 2:

  2

Example Explanation
Explanation 1:

  The only occurrence is at second position.
Explanation 2:

  Bob occures at first and third position.
 */
using System.Text;

public static class CountOccurrences
{
    public static int solve(string A)
    {
        int count = 0;

        for (int i = 0; i < A.Length; i++) {

            if(i<=A.Length-3) {

                string s = A.Substring(i, 3);

                if (s == "bob") { count++; }
            }
        }

        return count;
    }
}
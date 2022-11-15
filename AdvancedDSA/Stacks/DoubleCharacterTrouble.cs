/*
You are given a string A.

An operation on the string is defined as follows:

Remove the first occurrence of the same consecutive characters. eg for a string "abbcd", 
the first occurrence of same consecutive characters is "bb".

Therefore the string after this operation will be "acd".

Keep performing this operation on the string until there are no more occurrences of the same 
consecutive characters and return the final string.

Problem Constraints
1 <= |A| <= 100000

Input Format
First and only argument is string A.

Output Format
Return the final string.

Example Input
Input 1:

 A = abccbc
Input 2:

 A = ab

Example Output
Output 1:

 "ac"
Output 2:

 "ab"

Example Explanation
Explanation 1:

Remove the first occurrence of same consecutive characters. eg for a string "abbc", 
the first occurrence of same consecutive characters is "bb".
Therefore the string after this operation will be "ac".
Explanation 2:

 No removals are to be done.
 */

using System.Text;

public static class DoubleCharacterTrouble
{
    public static string solve(string A)
    {
        Stack<char> chars = new Stack<char>();

        for (int i = 0; i < A.Length; i++) {

            if(chars.Count == 0) {
                chars.Push(A[i]);
            }
            else {

                if (chars.Peek() == A[i]) {
                    chars.Pop();
                }
                else {
                    chars.Push(A[i]);
                }
            }
        }

        char[] str = new char[chars.Count];

        int N = chars.Count - 1;

        while(chars.Count > 0) {
            str[N--] = chars.Pop();
        }

        return new string(str);
    }
}
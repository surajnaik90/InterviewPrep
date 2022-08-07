/*
Given a string A consisting of lowercase characters.

Check if characters of the given string can be rearranged to form a palindrome.

Return 1 if it is possible to rearrange the characters of the string A such that it becomes a palindrome else return 0.

Problem Constraints
1 <= |A| <= 105

A consists only of lower-case characters.

Input Format
First argument is an string A.

Output Format
Return 1 if it is possible to rearrange the characters of the string A such that it becomes a palindrome else return 0.

Example Input
Input 1:

 A = "abcde"
Input 2:

 A = "abbaee"

Example Output
Output 1:

 0
Output 2:

 1

Example Explanation
Explanation 1:

 No possible rearrangement to make the string palindrome.
Explanation 2:

 Given string "abbaee" can be rearranged to "aebbea" to form a palindrome.
 */
public static class CheckPalindromeII
{
    public static int solve(string A)
    {
        Dictionary<char,int> map = new Dictionary<char,int>();

        for (int i = 0; i < A.Length; i++) {

            if (map.ContainsKey(A[i])) {
                map[A[i]] += 1;
            }
            else {
                map[A[i]] = 1;
            }
        }

        // Every element has to be multiple of 2
        // All 2's or All 2's with just 1 or any odd number
        short oddCount = 0;
        for (int i = 0; i < map.Count; i++) {

            int value = map.ElementAt(i).Value;

            if (value%2!=0) {
                oddCount++;
            }
        }

        if (oddCount < 2) { 
            return 1;
        }
        else {
            return 0;
        }
    }
}
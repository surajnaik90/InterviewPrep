/*
Given a string A, find the length of the longest substring without repeating characters.

Note: Users are expected to solve in O(N) time complexity.

Problem Constraints
1 <= size(A) <= 106

String consists of lowerCase,upperCase characters and digits are also present in the string A.

Input Format
Single Argument representing string A.

Output Format
Return an integer denoting the maximum possible length of substring without repeating characters.

Example Input
Input 1:

 A = "abcabcbb"
Input 2:

 A = "AaaA"

Example Output
Output 1:

 3
Output 2:

 2

Example Explanation
Explanation 1:

Substring "abc" is the longest substring without repeating characters in string A.
Explanation 2:

Substring "Aa" or "aA" is the longest substring without repeating characters in string A.
 */

public static class LongestSubstringHashMap
{
    public static int solve(string A)
    {
        int length = int.MinValue, l = 0, r = 0, N = A.Length;
        Dictionary<char,int> map = new Dictionary<char,int>();
        map.Add(A[0], 1); r++;

        while(r < N) {

            if (map.ContainsKey(A[r])) {
                map[A[r]]++;
            }
            else {
                map.Add(A[r], 1);
            }

            if (!isUniqueCharHashMap(map)) {

                while (A[l] != A[r]) {
                    l++;
                }
            }
            else {
                length = Math.Max(length, r - l + 1);
                r++;
            }
        }

        return length;
    }

    private static bool isUniqueCharHashMap(Dictionary<char,int> map)
    {
        bool isUnique = true; int N = map.Count;

        for (int i = 0; i < N; i++) {

            if(map.ElementAt(i).Value > 1) {
                return false;
            }
        }

        return isUnique;
    }
}
/*
You are given a string A of size N consisting of lowercase alphabets.

You can change at most B characters in the given string to any other lowercase alphabet such that the number of distinct 
characters in the string is minimized.

Find the minimum number of distinct characters in the resulting string.

Problem Constraints
1 <= N <= 100000

0 <= B < N

Input Format
The first argument is a string A.

The second argument is an integer B.

Output Format
Return an integer denoting the minimum number of distinct characters in the string.

Example Input
A = "abcabbccd"
B = 3

Example Output
2

Example Explanation
We can change both 'a' and one 'd' into 'b'.So the new string becomes "bbcbbbccb".
So the minimum number of distinct character will be 2.
 */

public static class ChangeCharacter
{
    public static int Operation1(string A, int B)
    {
        Dictionary<char, int> charCounts = new Dictionary<char, int>();
        List<int> list = new List<int>();

        for (int i = 0; i < A.Length; i++) {

            if (charCounts.ContainsKey(A[i])) {
                charCounts[A[i]] += 1;
            }
            else {
                charCounts[A[i]] = 1;
            }
        }

        for (int i = 0; i < charCounts.Count; i++) {
            list.Add(charCounts.ElementAt(i).Value);
        }

        int N = B, count=0, j=0; list.Sort();
        while (N> 0) {
            N -= list[j++];
            if (N >= 0) { count++; }
        }

        return (charCounts.Keys.Count - count);
    }
}
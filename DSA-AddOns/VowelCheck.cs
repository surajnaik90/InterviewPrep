/* Vowels in a range

Problem Description

Given a string A of length N consisting of lower case alphabets and Q queries given by the 2D array B of size Q*2. 
Each query consists of two integers B[i][0] and B[i][1].
For every query, the task is to find the count of vowels in the substring A[B[i][0]...B[i][1]].

Problem Constraints

1<=N<=10
1<=Q<=105
0 <= BiiJ[0] <= BiiJ[1] < N

Input Format

First argument A is a string.
Second argument B is a 2D array of integers.
 */
public static class VowelCheck
{
    public static List<int> Operation1(string A, List<List<int>> B)
    {
        int count = 0; List<int> output = new List<int>();
        char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
        int[] prefixVowels = new int[A.Length];

        prefixVowels[0] = (vowels.Contains(A[0]) == true) ? 1 : 0;
        for (int i = 1; i < A.Length; i++) {

            if (vowels.Contains(A[i]))
            {
                prefixVowels[i] = prefixVowels[i - 1] + 1;
                continue;
            }
            prefixVowels[i] = prefixVowels[i - 1];
        }

        for (int i = 0; i < B.Count; i++) {

            int s = B[i][0], e = B[i][1];

            if (s == 0) {
                count = prefixVowels[e];
            }
            else {
                count = prefixVowels[e] - prefixVowels[s - 1];
            }
            output.Add(count);
        }

        return output;
    }
}
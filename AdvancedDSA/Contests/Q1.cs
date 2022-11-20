/*
Given an integer, A. Find and Return first positive A integers in ascending order containing only digits 1, 2, and 3.

NOTE: All the A integers will fit in 32-bit integers.

Problem Constraints
1 <= A <= 29500

Input Format
The only argument given is integer A.

Output Format
Return an integer array denoting the first positive A integers in ascending order containing only digits 1, 2 and 3.

Example Input
Input 1:

 A = 3
Input 2:

 A = 7

Example Output
Output 1:

 [1, 2, 3]
Output 2:

 [1, 2, 3, 11, 12, 13, 21]

Example Explanation
Explanation 1:

 Output denotes the first 3 integers that contains only digits 1, 2 and 3.
Explanation 2:

 Output denotes the first 3 integers that contains only digits 1, 2 and 3.
 */

using System.Text;

public static class Q1
{
    public static List<int> solve(List<int> A)
    {
        List<int> res = new List<int>();

        

        A.Sort();

        int N = A.Count, mid = N / 2;
        int mod = (int)(Math.Pow(10, 9) + 7);

        int count = 1, sum = 0;

        int i = 0, j = mid;
        while (count <= mid)
        {

            sum += Math.Abs(A[i++] - A[j++]);
            sum %= mod;

            count++;
        }

        res.Add(sum);

        //Calculate Min
        i = 0; j = 1; sum = 0;
        while (j < N)
        {

            sum += Math.Abs(A[i] - A[j]);
            sum %= mod;

            i += 2; j += 2;
        }

        res.Add(sum);

        return res;
    }
}
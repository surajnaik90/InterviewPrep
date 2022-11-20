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

public static class Q5
{
    public static int solve(int A, int B)
    {
        List<int> numbers = new List<int>();

        for (int i = 1; i < 1000000; i++) {

            int num = i, count = 0, freq = 0;
            while (count < 32) {

                if ((num & (1 << count++)) > 0) {
                    freq++;

                    if (freq == 3) {
                        numbers.Add(num);
                        break;
                    }
                }
            }
        }

        int ans = int.MaxValue; int res = 0;
        for (int i = 0; i < numbers.Count; i++)
        {

            if ((A ^ numbers[i]) < ans)
            {
                ans = (A ^ numbers[i]);

                res = numbers[i];
            }
        }

        return res;
    }
}
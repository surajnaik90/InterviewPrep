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

public static class NIntegers
{
    public static List<int> solve(int A)
    {
        List<int> result = new List<int>();

        Queue<int> q = new Queue<int>();

        q.Enqueue(1); result.Add(1);
        if (A == 1) { return result; }

        q.Enqueue(2); result.Add(2);
        if (A == 2) { return result; }

        q.Enqueue(3); result.Add(3);
        if (A == 3) { return result; }

        int number; int count = 3;

        for (int i = 1; i <= A; i++) {

            number = q.Dequeue();
            count--;

            if (result.Count == A) { return result; }

            int n = (number * 10) + 1;
            q.Enqueue(n);
            result.Add(n);
            count++;
            if (result.Count == A) { return result; }

            n = (number * 10) + 2;
            q.Enqueue(n);
            result.Add(n);
            count++;
            if (result.Count == A) { return result; }

            n = (number * 10) + 3;
            q.Enqueue(n);
            result.Add(n);
            count++;
            if (result.Count == A) { return result; }
        }

        return result;
    }
}
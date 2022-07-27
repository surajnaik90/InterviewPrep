﻿/*
Given three 2-digit integers, A, B, and C, find out the minimum number obtained by concatenating them in any order.

Return the minimum result obtained.

Problem Constraints
10 <= A, B, C <= 99

Input Format
The first argument of input contains an integer, A.

The second argument of input contains an integer, B.

The third argument of input contains an integer, C.

Output Format
Return an integer representing the answer.

Example Input
Input 1:

 A = 10
 B = 20
 C = 30
Input 2:

 A = 55
 B = 43
 C = 47 


Example Output
Output 1:

 102030 
Output 2:

 434755 


Example Explanation
Explanation 1:

 10 + 20 + 30 = 102030 
Explanation 2:

 43 + 47 + 55 = 434755
 */

public static class Concatentate3Numbers
{
    public static int Operation1(int A, int B, int C)
    {
        int output=0;

        int s, m, l;
        int[] arr = new int[3] { A, B, C };

        for (int i = 0; i < 3; i++)
        {
            s = arr[i]; m = arr[(i + 1) % 3]; l = arr[(i + 2) % 3];

            if (s % m == s || s == m)
            {
                if (s % l == s || s == l)
                {
                    string res;

                    if (m < l) {
                        res = s.ToString() + m.ToString() + l.ToString();
                    }
                    else {
                        res = s.ToString() + l.ToString() + m.ToString();
                    }

                    output= Convert.ToInt32(res);

                    return output;
                }
            }
        }

        return output;
    }
}
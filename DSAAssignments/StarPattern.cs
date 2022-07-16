/*
Write a program to input an integer N from user and print hollow diamond star pattern series of N lines.

See example for clarifications over the pattern.



Problem Constraints

1 <= N <= 1000



Input Format

First line is an integer N



Output Format

N lines conatining only char '*' as per the question.



Example Input

Input 1:

4
Input 2:

6


Example Output

Output 1:

********
***  ***
**    **
*      *
*      *
**    **
***  ***
********
Output 2:

************
*****  *****
****    ****
***      ***
**        **
*          *
*          *
**        **
***      ***
****    ****
*****  *****
************
 */

public static class StarPattern
{
    public static void Operation1(int N)
    {
        int M = 2 * N;
        int[] spaceArray = new int[M];


        int delta = 2, count = (M % 2 == 0) ? 2 : 1;
        for (int i = 1; i <= M-2; i++)
        {
            spaceArray[i] = count;

            if (count % M == 0)
            {
               delta = -2;
               count += delta;

               if(M%2 !=0 ) { count += delta; }

               spaceArray[i] = count;
            }
            count += delta;
        }

        int a, b;
        for (int r = 0; r < M; r++)
        {
            a = (M - spaceArray[r]) / 2; b = a + spaceArray[r] - 1;

            for (int c = 0; c < M; c++)
            {
                if (a <= c && c <= b) { 
                    Console.Write(" ");
                }
                else {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}
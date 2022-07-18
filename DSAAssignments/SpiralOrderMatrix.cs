/*
Given an integer A, generate a square matrix filled with elements from 1 to A2 in spiral order.



Problem Constraints
1 <= A <= 1000



Input Format
First and only argument is integer A


Output Format
Return a 2-D matrix which consists of the elements in spiral order.



Example Input
Input 1:

1
Input 2:

2


Example Output
Output 1:

[ [1] ]
Output 2:

[ [1, 2], [4, 3] ]


Example Explanation
Explanation 1:

 
Only 1 is to be arranged.
Explanation 2:

1 --> 2
      |
      |
4<--- 3
 */

public static class SpiralOrderMatrix
{
    public static List<List<int>> Operation1(int A)
    {
        int[,] result = new int[A, A];
        int matrixSize = A, delta, number=1, r=0, c=matrixSize-1;
        int count = 0, rinc, cinc;

        for (int i = 0; i < (((2*(A-1))+1)); i++, count++)
        {
            if(i!=0 && i%4==0) { matrixSize -= 2; r++; c--; }

            delta = (count != 0 && count % 2 == 0) ? -1 : 1;

            if (i % 2 == 0) { 
                cinc = delta; rinc = 0; 
            }
            else { 
                rinc = delta; cinc = 0;
            }

            for (int j = 0; j < matrixSize; j = j++) { 

                result[r, c] = number++;

                r += rinc; c += cinc;
            }
        }

        List<List<int>> output = new List<List<int>>();
        for (int i = 0; i < A; i++)
        {
            List<int> row = new List<int>();
            for (int j = 0; j < A; j++)
            {
                row.Add(result[i,j]);
            }
            output.Add(row);
        }

        return output;
    }
}
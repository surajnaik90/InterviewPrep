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
        int matrixSize = A+2, delta=1, number=1, x=-1, y=A,r=x,c=0;
        int rinc, cinc, count=0;

        for (int i = 0; i < (((2 * (A - 1)) + 1)); i++, count++)
        {
            if(i%4==0) { matrixSize -= 2; x++; y--; r = x; c = r; }

            if (count != 0 && count % 2 == 0) {

                delta = delta == 1 ? -1 : 1;

                r = (i % 4 == 0) ? x : y;
            }

            if (i % 2 == 0){
                cinc = delta; rinc = 0;
            }
            else {
                rinc = delta; cinc = 0;
            }

            c = (i % 2 == 0) ? r : ((r == y) ? x : y);

            for (int j = 0; j < matrixSize; j++) {

                if(result[r, c] == 0) {
                    result[r, c] = number++;
                }

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
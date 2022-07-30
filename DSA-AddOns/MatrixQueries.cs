/* Matrix Game

Problem Description

Write a program to input two integers N and M. Now you have a 2-D array A of size N * M.
It has all the integers from 1 to N * M exactly once and they are inserted in this 2-D array
sequentially in a row major order.

E.g.Suppose N = 2 and M = 3, then 2-D array is {{1,2,3},{4,5,6}}
Now you have Q queries of following four types:

1 C1 C2: Swap elements of Column C1 with Column C2.
2 R1R2: Swap elements of Row R1 with Row R2.
3 X1/Y1 X2 Y2: Print the Bitwise OR of element A[X1][Y1] with A[X2][Y2] in updated 2-D array.
4 X1Y1 X2 Y2: Print the Bitwise AND of element A[X1][Y1] with A[X2][Y2] in updated 2-D array.

Problem Constraints

1<=N,M, Q <= 100000
1<=R1, R2, X1, X2<=N
1<=C1,C2,Y1,Y2<=M

 */
public static class MatrixQueries
{
    public static void Operation1()
    {
        string userInput = Console.ReadLine();

        int N = Convert.ToInt32((userInput.Split(' '))[0]);
        int M = Convert.ToInt32((userInput.Split(' '))[1]);
        int Q = Convert.ToInt32((userInput.Split(' '))[2]);

        int[,] matrix = new int[N, M];
        for (int i = 0; i < N; i++)
        {

            userInput = Console.ReadLine();

            for (int j = 0; j < M; j++)
            {
                matrix[i, j] = Convert.ToInt32((userInput.Split(' '))[j]);
            }
        }

        List<List<int>> queries = new List<List<int>>();
        for (int k = 0; k < Q; k++)
        {

            userInput = Console.ReadLine();

            List<int> query = new List<int>();

            int item = Convert.ToInt32((userInput.Split(' '))[0]);
            query.Add(item);

            switch (item)
            {
                case 1:
                    for (int i = 0; i < 2; i++)
                    {
                        int input = Convert.ToInt32((userInput.Split(' '))[i+1]);
                        query.Add(input);
                    }
                    break;

                case 2:
                    for (int i = 0; i < 2; i++)
                    {
                        int input = Convert.ToInt32((userInput.Split(' '))[i+1]);
                        query.Add(input);
                    }
                    break;

                case 3:
                    for (int i = 0; i < 4; i++)
                    {
                        int input = Convert.ToInt32((userInput.Split(' '))[i+1]);
                        query.Add(input);
                    }
                    break;

                case 4:
                    for (int i = 0; i < 4; i++)
                    {
                        int input = Convert.ToInt32((userInput.Split(' '))[i+1]);
                        query.Add(input);
                    }
                    break;
            }

            queries.Add(query);
        }

        //Compute the output
        for (int k = 0; k < Q; k++)
        {
            int queryType = queries[k][0]; int x1, y1, x2, y2, res;

            switch (queryType)
            {
                case 1:
                    //Swap column elements
                    int c1 = queries[k][1]-1, c2 = queries[k][2]-1;
                    for (int i = 0; i < N; i++)
                    {   
                        for (int j = 0; j < M; j++)
                        {
                            if(j==c1) {
                                int temp = matrix[i, c1];
                                matrix[i, c1] = matrix[i, c2];
                                matrix[i, c2] = temp;
                            }
                        }
                    }
                    break;

                case 2:
                    //Swap row elements
                    int r1 = queries[k][1] - 1, r2 = queries[k][2] - 1;
                    for (int i = 0; i < N; i++)
                    {
                        if(i==r1)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                int temp = matrix[r1, j];
                                matrix[r1, j] = matrix[r2, j];
                                matrix[r2, j] = temp;
                            }
                            break;
                        }
                    }
                    break;

                case 3:

                    x1 = queries[k][1] - 1; y1 = queries[k][2]-1;
                    x2 = queries[k][3] - 1; y2 = queries[k][4]-1;

                    res = matrix[x1, y1] | matrix[x2, y2];

                    Console.WriteLine(res);

                    break;

                case 4:
                    x1 = queries[k][1] - 1; y1 = queries[k][2] - 1;
                    x2 = queries[k][3] - 1; y2 = queries[k][4] - 1;

                    res = matrix[x1, y1] & matrix[x2, y2];

                    Console.WriteLine(res);
                    break;
            }
        }

    }
}
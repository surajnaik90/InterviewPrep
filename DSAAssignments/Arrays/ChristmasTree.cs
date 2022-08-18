/*
You are given an array A consisting of heights of Christmas trees and an array B of the same size consisting of the cost of each of the trees (Bi is the cost of tree Ai, where 1 ≤ i ≤ size(A)), and you are supposed to choose 3 trees (let's say, indices p, q, and r), such that Ap < Aq < Ar, where p < q < r.
The cost of these trees is Bp + Bq + Br.

You are to choose 3 trees such that their total cost is minimum. Return that cost.

If it is not possible to choose 3 such trees return -1.



Problem Constraints
1 <= A[i], B[i] <= 109
3 <= size(A) = size(B) <= 3000



Input Format
First argument is an integer array A.
Second argument is an integer array B.



Output Format
Return an integer denoting the minimum cost of choosing 3 trees whose heights are strictly in increasing order, if not possible, -1.



Example Input
Input 1:

 A = [1, 3, 5]
 B = [1, 2, 3]
Input 2:

 A = [1, 6, 4, 2, 6, 9]
 B = [2, 5, 7, 3, 2, 7]


Example Output
Output 1:

 6 
Output 2:

 7 


Example Explanation
Explanation 1:

 We can choose the trees with indices 1, 2 and 3, and the cost is 1 + 2 + 3 = 6. 
Explanation 2:

 We can choose the trees with indices 1, 4 and 5, and the cost is 2 + 3 + 2 = 7. 
 This is the minimum cost that we can get.
 */

public static class ChristmasTree
{
    //Brute force approach - Time Limit Exceeds
    public static int Operation1(List<int> A, List<int> B)
    {
        int output = int.MaxValue, N=A.Count;

        for (int i = 0; i < N; i++)
        {
            for (int j = i+1; j < N; j++)
            {
                if (A[j] > A[i])
                {
                    for (int k = j+1; k < N; k++)
                    {
                        if(A[k] > A[j]) {

                            int cost;

                            cost = B[k] + B[j] + B[i];

                            if (cost < output) {
                                output = cost;
                            }

                        }
                    }
                }

            }
        }

        if(output == int.MaxValue) { output = -1; }

        return output;
    }

    //Optimized solution
    public static int Operation2(List<int> A, List<int> B)
    {
        int output = int.MaxValue, N = A.Count;

        for (int i = 1; i <= A.Count-2; i++) {

            int left = i-1, right = i+1;

            int left_min_cost = int.MaxValue;
            while (left >= 0) {

                if (A[left] < A[i]) {
                    left_min_cost = Math.Min(left_min_cost, B[left]);
                }
                left--;
            }


            int right_min_cost = int.MaxValue;
            while (right < A.Count) {

                if (A[right] > A[i]) {
                    right_min_cost = Math.Min(right_min_cost, B[right]);
                }
                right++;
            }

            if (left_min_cost == int.MaxValue || right_min_cost == int.MaxValue) {
                continue;
            }
            else {
                output = Math.Min(output, left_min_cost + right_min_cost + B[i]);
            }
        }

        if (output == int.MaxValue) {
            return -1;
        }
        return output;
    }
}
﻿/*
We have a list A of points (x, y) on the plane. Find the B closest points to the origin (0, 0).

Here, the distance between two points on a plane is the Euclidean distance.

You may return the answer in any order. The answer is guaranteed to be unique (except for the order that it is in.)

NOTE: Euclidean distance between two points P1(x1, y1) and P2(x2, y2) is sqrt( (x1-x2)2 + (y1-y2)2 ).

Problem Constraints
1 <= B <= length of the list A <= 105
-105 <= A[i][0] <= 105
-105 <= A[i][1] <= 105

Input Format
The argument given is list A and an integer B.

Output Format
Return the B closest points to the origin (0, 0) in any order.

Example Input
Input 1:

 A = [ 
       [1, 3],
       [-2, 2] 
     ]
 B = 1
Input 2:

 A = [
       [1, -1],
       [2, -1]
     ] 
 B = 1

Example Output
Output 1:

 [ [-2, 2] ]
Output 2:

 [ [1, -1] ]


Example Explanation
Explanation 1:

 The Euclidean distance will be sqrt(10) for point [1,3] and sqrt(8) for point [-2,2].
 So one closest point will be [-2,2].
Explanation 2:

 The Euclidean distance will be sqrt(2) for point [1,-1] and sqrt(5) for point [2,-1].
 So one closest point will be [1,-1].
 */

public static class BClosestPointsOrigin
{
    public static List<List<int>> solve(List<List<int>> A, int B)
    {
        List<List<int>> res = new List<List<int>>();

        A.Sort(new PointsComparer());

        for (int i = 0; i < B; i++) {
            res.Add(A[i]);
        }

        return res;
    }

    //No need to compute the sqrt because sqrt(16) > sqrt(9) => 4 > 3
    private class PointsComparer : IComparer<List<int>>
    {
        public int Compare(List<int>? x, List<int>? y)
        {
            long sum1 = 0, sum2 = 0;

            for (int i = 0; i < 2; i++) {
                sum1 += (long) (x[i] * x[i]);
                sum2 += (long) (y[i] * y[i]);
            }

            if(sum1 < sum2) {
                return -1;
            }
            else if (sum1 == sum2) {
                return 0;
            }
            else {
                return 1;
            }
        }
    }
}
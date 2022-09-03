/*
Eight integers A, B, C, D, E, F, G, and H represent two rectangles in a 2D plane.
For the first rectangle, its bottom left corner is (A, B), and the top right corner is (C, D),
and for the second rectangle, its bottom left corner is (E, F), and the top right corner is (G, H).

Find and return whether the two rectangles overlap or not.

Problem Constraints
-10000 <= A < C <= 10000
-10000 <= B < D <= 10000
-10000 <= E < G <= 10000
-10000 <= F < H <= 10000

Input Format
The eight arguments are integers A, B, C, D, E, F, G, and H.

Output Format
Return 1 if the two rectangles overlap else, return 0.

Example Input
Input 1:

A = 0   B = 0
C = 4   D = 4
E = 2   F = 2
G = 6   H = 6
 
Input 2:

A = 0   B = 0
C = 4   D = 4
E = 2   F = 2
G = 3   H = 3

Example Output
Output 1:
1
Output 2:
1

Example Explanation

Explanation 1:
Rectangle with bottom left (2, 2) and top right (4, 4) is overlapping.
Explanation 2:
Overlapping rectangles can be found.

 */

public static class TwoRectanglesOverlap
{
    public static int Operation1(int A, int B, int C, int D, int E, int F, int G, int H)
    {
        if (
            ((A <= E && E <= C) || (A <= G && G <= C)) && 
            (!((B <= F && F <= D) && (B <= H && H <= D)))
           )
        {
            return 0;
        }

        if (
            ((E <= A && A <= G) || (E <= C && C <= G)) &&
            (!((F <= B && B <= H) && (F <= D && D <= H)))
           )
        {
            return 0;
        }

        if (
            ((B <= F && F <= D) || (B <= H && H <= D)) &&
            (!((A <= E && E <= C) && (A <= G && G <= C)))
           )
        {
            return 0;
        }

        if (
            ((F <= B && B <= H) || (F <= D && D <= H)) &&
            (!((E <= A && A <= G) && (E <= C && C <= G)))
           )
        {
            return 0;
        }

        if (
            (!((A <= E && E <= C) && (A <= G && G <= C))) &&
            (!((B <= F && F <= D) && (B <= H && H <= D)))
           )
        {
            return 0;
        }

        if (
            (!((E <= A && A <= G) && (E <= C && C <= G))) &&
            (!((F <= B && B <= H) && (F <= D && D <= H)))
           )
        {
            return 0;
        }

        return 1;
    }

    public static int Operation2(int A, int B, int C, int D, int E, int F, int G, int H)
    {
        int[,] rectangleA = new int[4, 2] { { A, B }, { C, B }, { C, D }, { A, D } };
        int[,] rectangleB = new int[4, 2] { { E, F }, { G, F }, { G, H }, { E, H } };

        
        for (int i = 0; i < 4; i++)
        {
            //If any one of rectangle B's co-ordinates falls within A 
            if ((A <= rectangleB[i, 0] && rectangleB[i, 0] <= C) &&
                (B <= rectangleB[i, 1] && rectangleB[i, 1] <= D))
            {
                return 1;
            }

            //If any one of rectangle A's co-ordinates falls within B 
            if ((E <= rectangleA[i, 0] && rectangleA[i, 0] <= G) &&
                (F <= rectangleA[i, 1] && rectangleA[i, 1] <= H))
            {
                return 1;
            }
        }

        /*
        if ((A <= E && E <= C) && (B <= F && F <= D)) {
            return 1;
        }

        if ((A <= G && G <= C) && (B <= H && H <= D)) {
            return 1;
        }

        if ((E <= A && A <= G) && (F <= B && B <= H))
        {
            return 1;
        }

        if ((E <= C && C <= G) && (F <= D && D <= H))
        {
            return 1;
        }
        
         


        int A = rec1[0], B= rec1[1], C = rec1[2], D = rec1[3];
        int E = rec2[0], F = rec2[1], G = rec2[2], H = rec2[3];

        int[,] rectangleA = new int[4, 2] { { A, B }, { C, B }, { C, D }, { A, D } };
        int[,] rectangleB = new int[4, 2] { { E, F }, { G, F }, { G, H }, { E, H } };

        for (int i = 0; i < 4; i++)
        {
            //If any one of rectangle B's co-ordinates falls within A 
            if ((C <= rectangleB[i, 0] && rectangleB[i, 0] <= A) &&
                (D <= rectangleB[i, 1] && rectangleB[i, 1] <= B))
            {
                return false;
            }

            //If any one of rectangle A's co-ordinates falls within B 
            if ((G <= rectangleA[i, 0] && rectangleA[i, 0] <= E) &&
                (H <= rectangleA[i, 1] && rectangleA[i, 1] <= F))
            {
                return false;
            }
        }
        return true;
         
         
         */

        return 0;
    }
}
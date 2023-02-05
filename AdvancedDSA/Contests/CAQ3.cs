/*
Given an integer array A of size N.

You have to find the product of the three largest integers in array A from range 1 to i, where i goes from 1 to N.

Return an array B where B[i] is the product of the largest 3 integers in range 1 to i in array A. 
If i < 3, then the integer at index i in B should be -1.

Problem Constraints
1 <= N <= 105
0 <= A[i] <= 103

Input Format
First and only argument is an integer array A.

Output Format
Return an integer array B. B[i] denotes the product of the largest 3 integers in range 1 to i in array A.

Example Input
Input 1:

 A = [1, 2, 3, 4, 5]
Input 2:

 A = [10, 2, 13, 4]


Example Output
Output 1:

 [-1, -1, 6, 24, 60]
Output 2:

 [-1, -1, 260, 520]


Example Explanation
Explanation 1:

 For i = 1, ans = -1
 For i = 2, ans = -1
 For i = 3, ans = 1 * 2 * 3 = 6
 For i = 4, ans = 2 * 3 * 4 = 24
 For i = 5, ans = 3 * 4 * 5 = 60

 So, the output is [-1, -1, 6, 24, 60].
 
Explanation 2:

 For i = 1, ans = -1
 For i = 2, ans = -1
 For i = 3, ans = 10 * 2 * 13 = 260
 For i = 4, ans = 10 * 13 * 4 = 520

 So, the output is [-1, -1, 260, 520].
 */


//https://github.com/dotnet/runtime/blob/main/src/libraries/System.Collections/src/System/Collections/Generic/PriorityQueue.cs
//https://visualstudiomagazine.com/Articles/2012/11/01/Priority-Queues-with-C.aspx?Page=2

using System.Collections.Generic;

public static class CAQ3
{

    public static int solve(TreeNode A, TreeNode B)
    {
        int ans = 0;

        if (A.val != B.val) {
            return -1;
        }

        Queue<TreeNode> a = new Queue<TreeNode>();
        Queue<int> avalues = new Queue<int>();
        avalues.Enqueue(A.val);

        Queue<TreeNode> b = new Queue<TreeNode>();
        Queue<int> bvalues = new Queue<int>();
        bvalues.Enqueue(B.val);

        a.Enqueue(A);
        b.Enqueue(B);

        while(a.Count > 0) {

            TreeNode node = a.Dequeue();

            if (node == null) {
                continue;
            }            

            if(node.left != null) {
                a.Enqueue(node.left);
                avalues.Enqueue(node.left.val);
            }
            else {
                a.Enqueue(null);
                avalues.Enqueue(-1);
            }

            if(node.right != null) {
                a.Enqueue(node.right);
                avalues.Enqueue(node.right.val);
            }
            else {
                a.Enqueue(null);
                avalues.Enqueue(-1);
            }
        }

        while (b.Count > 0)
        {

            TreeNode node = b.Dequeue();

            if (node == null)
            {
                continue;
            }

            if (node.left != null)
            {
                b.Enqueue(node.left);
                bvalues.Enqueue(node.left.val);
            }
            else
            {
                b.Enqueue(null);
                bvalues.Enqueue(-1);
            }

            if (node.right != null)
            {
                b.Enqueue(node.right);
                bvalues.Enqueue(node.right.val);
            }
            else
            {
                b.Enqueue(null);
                bvalues.Enqueue(-1);
            }
        }

        while(avalues.Count > 0) {

            int valA = avalues.Dequeue();

            int valB = bvalues.Dequeue();

            if(valA == valB) {
                continue;
            }


        }


        return ans;
    }

    public static int solve2(TreeNode A, TreeNode B)
    {
        int ans = 0; 

        Queue<TreeNode> a = new Queue<TreeNode>();
        Queue<TreeNode> b = new Queue<TreeNode>();
        
        if(A.val != B.val) {
            return -1;
        }

        a.Enqueue(A); b.Enqueue(B);

        while(a.Count > 0) {

            TreeNode nodeA = a.Dequeue();
            TreeNode nodeB = b.Dequeue();

            if(nodeA == null && nodeB != null) {
                ans++;

                a.Enqueue(null);
                a.Enqueue(nodeA.left);

                b.Enqueue(nodeB.left);
                b.Enqueue(nodeB.right);
            }
            else if(nodeA != null && nodeB == null) {
                ans++;

                a.Enqueue(nodeA.right);
                a.Enqueue(nodeA.left);

                b.Enqueue(nodeB.left);
                b.Enqueue(nodeB.right);
            }

            if(nodeA == null && nodeB == null) {
                continue;
            }

            if(nodeA.left.val == nodeB.left.val) {
                a.Enqueue(nodeA.left);
                b.Enqueue(nodeB.left);
            }
            else {

                ans++;

                a.Enqueue(nodeA.right);
                a.Enqueue(nodeA.left);

                b.Enqueue(nodeB.left);
                b.Enqueue(nodeB.right);
            }


        }

        return ans;
    }
}
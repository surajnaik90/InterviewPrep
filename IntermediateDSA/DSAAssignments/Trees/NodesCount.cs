﻿/*
You are given the root node of a binary tree A. You have to find the number of nodes in this tree.

Problem Constraints
1 <= Number of nodes in the tree <= 105

0 <= Value of each node <= 107

Input Format
The first and only argument is a tree node A.

Output Format
Return an integer denoting the number of nodes of the tree. 

Example Input
Input 1:

 Values =  1 
          / \     
         4   3                        
Input 2:

 
 Values =  1      
          / \     
         4   3                       
        /         
       2                                     


Example Output
Output 1:

 3 
Output 2:

 4 

Example Explanation
Explanation 1:

Clearly, there are 3 nodes 1, 4 and 3.
Explanation 2:

Clearly, there are 4 nodes 1, 4, 3 and 2.
 */
public static class NodesCount
{
    public static int solve(TreeNode A)
    {
        if(A==null) { return 0; }

        int output = 0;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(A); output++;

        while(stack.Count != 0) {

            TreeNode node = stack.Pop();

            if (node.left != null) {
                stack.Push(node.left);
                output++;
            }
             
            if (node.right != null) {
                stack.Push(node.right);
                output++;
            }
        }

        return output;
    }
}
﻿/*
 You are given the root node of a binary tree A. You have to find the height of the given tree.

A binary tree's height is the number of nodes along the longest path from the root node down to the farthest leaf node.

Problem Constraints
1 <= Number of nodes in the tree <= 105

0 <= Value of each node <= 109

Input Format
The first and only argument is a tree node A.

Output Format
Return an integer denoting the height of the tree.

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

 2 
Output 2:

 3 

Example Explanation
Explanation 1:

 Distance of node having value 1 from root node = 1
 Distance of node having value 4 from root node = 2 (max)
 Distance of node having value 3 from root node = 2 (max)
Explanation 2:

 Distance of node having value 1 from root node = 1
 Distance of node having value 4 from root node = 2
 Distance of node having value 3 from root node = 2
 Distance of node having value 2 from root node = 3 (max)
 */
public static class TreeHeight
{
    //Created a custom stack & have not used the language provided stack
    public static int solve(TreeNode A)
    {
        if (A == null) { return 0; }

        int output = 0;

        output = Math.Max(output, calculateHeight(A.right));

        output = Math.Max(output, calculateHeight(A.left));
        
        return output+1;
    }

    public static int calculateHeight(TreeNode treeNode)
    {

        if(treeNode == null) { return 0; }

        int output = 1;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(treeNode);

        while(stack.Count > 0) {

            TreeNode node = stack.Pop();

            if (node.left != null && node.right != null) {

                if (node.left.val != -1 || node.right.val != -1) {
                    output++;
                }
            }

            if (node.right != null && node.right.val != -1) {
                stack.Push(node.right);
            }
            if(node.left != null && node.left.val != -1) {
                stack.Push(node.left);
            }
        }

        return output;
    }
}
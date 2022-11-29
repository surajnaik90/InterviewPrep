/*
You are given a binary tree represented by root A.

Assume a BST is defined as follows:

1) The left subtree of a node contains only nodes with keys less than the node's key.

2) The right subtree of a node contains only nodes with keys greater than the node's key.

3) Both the left and right subtrees must also be binary search trees.

Problem Constraints
1 <= Number of nodes in binary tree <= 105

0 <= node values <= 232-1

Input Format
First and only argument is head of the binary tree A.

Output Format
Return 0 if false and 1 if true.

Example Input
Input 1:
 
   1
  /  \
 2    3
Input 2:

 
  2
 / \
1   3


Example Output
Output 1:

 0
Output 2:

 1


Example Explanation
Explanation 1:

 2 is not less than 1 but is in left subtree of 1.
Explanation 2:

Satisfies all conditions.
 */
public static class ValidateBST
{
    public static int solve(TreeNode A)
    {
        int isValidBST;

        bool res = isBST(A, int.MinValue, int.MaxValue);

        isValidBST = res == true ? 1 : 0; 

        return isValidBST;
    }

    public static bool isBST(TreeNode root, int l, int r)
    {
        bool isLST, isRST;
        
        if(root == null) { return true; }

        if(root.val < l || root.val > r) { return false; }

        isLST = isBST(root.left, l, root.val - 1);

        isRST = isBST(root.right, root.val + 1, r);

        return isLST && isRST;
    }
}
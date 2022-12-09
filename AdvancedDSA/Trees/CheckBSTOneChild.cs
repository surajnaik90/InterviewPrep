/*
Given preorder traversal of a binary tree, check if it is possible that it is also a 
preorder traversal of a Binary Search Tree (BST), where each internal node (non-leaf nodes) have exactly one child.

Problem Constraints

1 <= number of nodes <= 100000

Input Format

First and only argument is an integer array denoting the preorder traversal of binary tree.

Output Format

Return a string "YES" if true else "NO".

Example Input

Input 1:

 A : [4, 10, 5, 8]
Input 2:

 A : [1, 5, 6, 4]

Example Output

Output 1:

 "YES"
Output 2:

 "NO"

Example Explanation

Explanation 1:

 The possible BST is:
            4
             \
             10
             /
             5
              \
              8
Explanation 2:

 There is no possible BST which have the above preorder traversal.
 */
using System.ComponentModel;

public static class CheckBSTOneChild
{
    public static string solve(List<int> A)
    {
        string ans = "YES";
        TreeNode root = new TreeNode(A[0]);

        isValidPreorderBST(root, 0, A, int.MinValue, int.MaxValue);

        return ans;
    }

    public static bool isValidPreorderBST(TreeNode node, int startIndex,
                                         List<int> list, int l, int r)
    {   
        bool isLeftValid = true, isRightValid = true;
        bool hasSingleChild = false;

        if(node.val < l || node.val > r) {
            return false;
        }

        int index = startIndex + 1;

        if (index < list.Count) {

            if (list[index] >= l && list[index] < r) {
                node.left = new TreeNode(list[index]);

                startIndex++;

               isLeftValid =  isValidPreorderBST(node.left, startIndex, list, l, node.val - 1);
            }
            else if (list[index] >= (node.val + 1) && list[index] < r) {
                node.right = new TreeNode(list[index]);

                startIndex++;

                isValidPreorderBST(node.right, startIndex, list, node.val + 1, r);
            }
        }

        return isLeftValid && isRightValid;
    }
}
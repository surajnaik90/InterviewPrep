/*
Given a binary tree, return the inorder traversal of its nodes' values.

NOTE: Using recursion is not allowed.

Problem Constraints
1 <= number of nodes <= 105

Input Format
First and only argument is root node of the binary tree, A.

Output Format
Return an integer array denoting the inorder traversal of the given binary tree.

Example Input
Input 1:

   1
    \
     2
    /
   3
Input 2:

   1
  / \
 6   2
    /
   3


Example Output
Output 1:

 [1, 3, 2]
Output 2:

 [6, 1, 3, 2]


Example Explanation
Explanation 1:

 The Inorder Traversal of the given tree is [1, 3, 2].
Explanation 2:

 The Inorder Traversal of the given tree is [6, 1, 3, 2].
 */

using System.Text;

public static class Inorder
{
    public static List<int> solve(TreeNode A)
    {
        List<int> res = new List<int>();

        Stack<TreeNode> stack = new Stack<TreeNode>();
        Stack<TreeNode> inorderStack = new Stack<TreeNode>();

        stack.Push(A);

        while(stack.Count > 0) {

            TreeNode node = stack.Peek();

            if(node.left != null) {
                stack.Push(node.left);
            }
            else {

                stack.Pop();
                res.Add(node.val);

                if (node.right == null) {

                    node = stack.Pop();
                    res.Add(node.val);
                }
                else {
                    stack.Push(node.right);
                }
            }
        }

        return res;
    }
}
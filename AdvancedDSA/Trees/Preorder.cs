/*
Given a binary tree, return the preorder traversal of its nodes values.

NOTE: Using recursion is not allowed.

Problem Constraints
1 <= number of nodes <= 105

Input Format
First and only argument is root node of the binary tree, A.

Output Format
Return an integer array denoting the preorder traversal of the given binary tree.

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

 [1, 2, 3]
Output 2:

 [1, 6, 2, 3]


Example Explanation
Explanation 1:

 The Preoder Traversal of the given tree is [1, 2, 3].
Explanation 2:

 The Preoder Traversal of the given tree is [1, 6, 2, 3].
 */
public static class Preorder
{
    public static List<int> solve(TreeNode A)
    {
        List<int> res = new List<int>();

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(A);

        while (stack.Count > 0) {

            TreeNode node = stack.Pop();

            res.Add(node.val);

            if (node.right != null) {
                stack.Push(node.right);
            }

            if (node.left != null) {
                stack.Push(node.left);
            }
        }

        return res;
    }
}
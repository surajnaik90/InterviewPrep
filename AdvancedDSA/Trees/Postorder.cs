/*
Given a binary tree, return the Postorder traversal of its nodes values.

NOTE: Using recursion is not allowed.

Problem Constraints
1 <= number of nodes <= 105

Input Format
First and only argument is root node of the binary tree, A.

Output Format
Return an integer array denoting the Postorder traversal of the given binary tree.

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

 [3, 2, 1]
Output 2:

 [6, 3, 2, 1]


Example Explanation
Explanation 1:

 The Preoder Traversal of the given tree is [3, 2, 1].
Explanation 2:

 The Preoder Traversal of the given tree is [6, 3, 2, 1].
 */
public static class Postorder
{
    public static List<int> solve(TreeNode A)
    {
        List<int> res = new List<int>();

        Stack<TreeNode> stack = new Stack<TreeNode>();
        Stack<TreeNode> postOrderStack = new Stack<TreeNode>();
        stack.Push(A);

        while (stack.Count > 0) {

            TreeNode node = stack.Peek();

            if(node.left == null && node.right == null) {
                postOrderStack.Push(stack.Pop());
                res.Add(node.val);
            }

            if(postOrderStack.Count > 0) {
                if (node.right == postOrderStack.Peek() ||
                node.left == postOrderStack.Peek()) {

                    postOrderStack.Push(stack.Pop());
                    res.Add(node.val);
                    continue;
                }
            }

            if (node.right != null) {
                stack.Push(node.right);
            }

            if(node.left != null) {
                stack.Push(node.left);
            }
        }

        return res;
    }
}
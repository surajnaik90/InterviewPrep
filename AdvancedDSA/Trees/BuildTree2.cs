/*
Given the inorder and postorder traversal of a tree, construct the binary tree.

NOTE: You may assume that duplicates do not exist in the tree.

Problem Constraints
1 <= number of nodes <= 105

Input Format
First argument is an integer array A denoting the inorder traversal of the tree.

Second argument is an integer array B denoting the postorder traversal of the tree.

Output Format
Return the root node of the binary tree.

Example Input
Input 1:

 A = [2, 1, 3]
 B = [2, 3, 1]
Input 2:

 A = [6, 1, 3, 2]
 B = [6, 3, 2, 1]

Example Output
Output 1:

   1
  / \
 2   3
Output 2:

   1  
  / \
 6   2
    /
   3

Example Explanation
Explanation 1:

 Create the binary tree and return the root node of the tree.

 */

using System.Text;
using System.Xml.Linq;

public static class BuildTree2
{
    public static TreeNode solve(List<int> postorder, List<int> inorder)
    {
        TreeNode root;

        root = build(postorder, inorder, 0, inorder.Count - 1,
                          0, postorder.Count - 1);

        return root;
    }

    public static TreeNode build(List<int> postorder, List<int> inorder,
                                 int in_s, int in_e, int post_s, int post_e)
    {

        if (in_s > in_e) { return null; }

        TreeNode node = new TreeNode(postorder[post_e]);

        int index = -1;
        for (int i = in_s; i <= in_e; i++) {

            if (inorder[i] == postorder[post_e]) {
                index = i;
                break;
            }
        }

        //No of nodes in the Left sub tree
        int k = index - in_s;

        node.left = build(postorder, inorder, in_s, index - 1, post_s, post_s + k - 1);

        node.right = build(postorder, inorder, index + 1, in_e, post_s + k, post_e - 1);

        return node;
    }
}
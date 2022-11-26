/*
Given preorder and inorder traversal of a tree, construct the binary tree.

NOTE: You may assume that duplicates do not exist in the tree.

Problem Constraints
1 <= number of nodes <= 105

Input Format
First argument is an integer array A denoting the preorder traversal of the tree.

Second argument is an integer array B denoting the inorder traversal of the tree.

Output Format
Return the root node of the binary tree.

Example Input
Input 1:

 A = [1, 2, 3]
 B = [2, 1, 3]
Input 2:

 A = [1, 6, 2, 3]
 B = [6, 1, 3, 2]

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

public static class BuildTree1
{
    public static TreeNode solve(List<int> preorder, List<int> inorder)
    {
        TreeNode root;

        root = build(preorder, inorder, 0, inorder.Count - 1,
                          0, preorder.Count - 1);

        return root;
    }

    public static TreeNode build(List<int> preorder, List<int> inorder, 
                                 int in_s, int in_e, int pre_s, int pre_e)
    {

        if(in_s > in_e) { return null; }

        TreeNode node = new TreeNode(preorder[pre_s]);

        int index = -1;
        for (int i = in_s; i <= in_e; i++) {

            if (inorder[i] == preorder[pre_s]) {
                index = i;
                break;
            }
        }

        //No of nodes in the Left sub tree
        int k = index - in_s;

        node.left = build(preorder, inorder, in_s, index - 1, pre_s + 1, pre_s + k);

        node.right = build(preorder, inorder, index+1, in_e, pre_s + k + 1, pre_e);

        return node;
    }
}
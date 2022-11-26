/*
Given the root node of a Binary Tree denoted by A. You have to Serialize the given Binary Tree in the described format.

Serialize means encode it into a integer array denoting the Level Order Traversal of the given Binary Tree.

NOTE:

In the array, the NULL/None child is denoted by -1.
For more clarification check the Example Input.

Problem Constraints
1 <= number of nodes <= 105

Input Format
Only argument is a A denoting the root node of a Binary Tree.

Output Format
Return an integer array denoting the Level Order Traversal of the given Binary Tree.

Example Input
Input 1:

           1
         /   \
        2     3
       / \
      4   5
Input 2:

            1
          /   \
         2     3
        / \     \
       4   5     6


Example Output
Output 1:

 [1, 2, 3, 4, 5, -1, -1, -1, -1, -1, -1]
Output 2:

 [1, 2, 3, 4, 5, -1, 6, -1, -1, -1, -1, -1, -1]


Example Explanation
Explanation 1:

 The Level Order Traversal of the given tree will be [1, 2, 3, 4, 5 , -1, -1, -1, -1, -1, -1].
 Since 3, 4 and 5 each has both NULL child we had represented that using -1.
Explanation 2:

 The Level Order Traversal of the given tree will be [1, 2, 3, 4, 5, -1, 6, -1, -1, -1, -1, -1, -1].
 Since 3 has left child as NULL while 4 and 5 each has both NULL child.
 */

using System.Text;
using System.Xml.Linq;

public static class Serialize
{
    public static List<int> solve(TreeNode A)
    {
        List<int> output = new List<int>();

        List<List<int>> res = new List<List<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        Queue<TreeNode> levelNodes = new Queue<TreeNode>();
        q.Enqueue(A); levelNodes.Enqueue(A);
        q.Enqueue(null); levelNodes.Enqueue(null);

        while (q.Count > 0) {

            TreeNode node = q.Dequeue();

            if (node == null && q.Count == 0) { break; }

            if (node == null) {
                q.Enqueue(null);
                levelNodes.Enqueue(null);
                continue;
            }
            else {
                if (node.left != null) {
                    q.Enqueue(node.left);
                    levelNodes.Enqueue(node.left);
                }

                if (node.right != null) {
                    q.Enqueue(node.right);
                    levelNodes.Enqueue(node.right);
                }
            }
        }

        List<int> lvlNodes = new List<int>();
        while (levelNodes.Count > 0) {

            TreeNode node = levelNodes.Dequeue();

            if (node == null) {
                res.Add(lvlNodes);
                lvlNodes = new List<int>();
            }
            else {
                lvlNodes.Add(node.val);
            }
        }

        return output;
    }
}
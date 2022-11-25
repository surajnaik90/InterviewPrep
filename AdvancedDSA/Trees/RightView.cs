/*
Given a binary tree of integers denoted by root A. 
Return an array of integers representing the right view of the Binary tree.

Right view of a Binary Tree is a set of nodes visible when the tree is visited from Right side.

Problem Constraints
1 <= Number of nodes in binary tree <= 100000

0 <= node values <= 10^9

Input Format
First and only argument is head of the binary tree A.

Output Format
Return an array, representing the right view of the binary tree.

Example Input
Input 1:

            1
          /   \
         2    3
        / \  / \
       4   5 6  7
      /
     8 

Input 2:

            1
           /  \
          2    3
           \
            4
             \
              5


Example Output
Output 1:

 [1, 3, 7, 8]
Output 2:

 [1, 3, 4, 5]


Example Explanation
Explanation 1:

Right view is described.
Explanation 2:

Right view is described.
 */

using System.Text;
using System.Xml.Linq;

public static class RightView
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

                int count = lvlNodes.Count;
                output.Add(lvlNodes[count - 1]);

                lvlNodes = new List<int>();
            }
            else {
                lvlNodes.Add(node.val);
            }
        }

        return output;
    }
}
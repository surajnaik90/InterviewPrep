/*
Given a binary tree, return the level order traversal of its nodes' values.
(i.e., from left to right, level by level).

Problem Constraints
1 <= number of nodes <= 105

Input Format
First and only argument is root node of the binary tree, A.

Output Format
Return a 2D integer array denoting the zigzag level order traversal of the given binary tree.

Example Input
Input 1:

    3
   / \
  9  20
    /  \
   15   7
Input 2:

   1
  / \
 6   2
    /
   3


Example Output
Output 1:

 [
   [3],
   [9, 20],
   [15, 7]
 ]
Output 2:

 [ 
   [1]
   [6, 2]
   [3]
 ]


Example Explanation
Explanation 1:

 Return the 2D array. Each row denotes the traversal of each level.
 */

using System.Text;
using System.Xml.Linq;

public static class LevelOrder
{
    public static List<List<int>> solve(TreeNode A)
    {
        List<List<int>> res = new List<List<int>>();

        Queue<TreeNode> q = new Queue<TreeNode>();
        Queue<TreeNode> levelNodes = new Queue<TreeNode>();
        q.Enqueue(A); levelNodes.Enqueue(A);
        q.Enqueue(null); levelNodes.Enqueue(null);

        while (q.Count > 0) {

            TreeNode node = q.Dequeue();

            if(node==null && q.Count == 0) { break; }

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

        return res;
    }
}
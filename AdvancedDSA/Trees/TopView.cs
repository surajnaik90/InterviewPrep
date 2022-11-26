/*
Given a binary tree of integers denoted by root A. 
Return an array of integers representing the top view of the Binary tree.

The top view of a Binary Tree is a set of nodes visible when the tree is visited from the top.

Return the nodes in any order.

Problem Constraints
1 <= Number of nodes in binary tree <= 100000

0 <= node values <= 10^9

Input Format
First and only argument is head of the binary tree A.

Output Format
Return an array, representing the top view of the binary tree.

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

 [1, 2, 4, 8, 3, 7]
Output 2:

 [1, 2, 3]

Example Explanation
Explanation 1:

Top view is described.
Explanation 2:

Top view is described.
 */
public static class TopView
{
    public static List<int> solve(TreeNode A)
    {
        List<int> res = new List<int>();

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(A); q.Enqueue(null);


        List<List<int>> levelNodes = new List<List<int>>();
        List<int> list = new List<int>();

        while (q.Count > 0) {

            TreeNode node = q.Dequeue();

            if (node == null && q.Count == 0) { break; }

            if (node == null) {
                q.Enqueue(null);
                levelNodes.Add(list);
                list = new List<int>();
                continue;
            }

            if (node.left != null) {
                q.Enqueue(node.left);
                list.Add(node.left.val);
            }

            if (node.right != null) {
                q.Enqueue(node.right);
                list.Add(node.right.val);
            }
        }
        return res;
    }
}
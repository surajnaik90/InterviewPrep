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
    public class VerticalNode
    {
        public TreeNode treeNode;
        public int verticalAxis;
        public VerticalNode(TreeNode node, int axis)
        {
            this.treeNode = node;
            this.verticalAxis = axis;
        }
    }
    public static List<int> solve(TreeNode A)
    {
        List<int> res = new List<int>();
        int min = 0, max = 0;

        Queue<VerticalNode> q = new Queue<VerticalNode>();
        Queue<VerticalNode> sq = new Queue<VerticalNode>();
        Dictionary<int, List<int>> axisNodes = new Dictionary<int, List<int>>();

        q.Enqueue(new VerticalNode(A, 0)); q.Enqueue(null);
        sq.Enqueue(new VerticalNode(A, 0)); sq.Enqueue(null);


        axisNodes.Add(0, new List<int>() { A.val });

        while (q.Count > 0)
        {

            VerticalNode verticalNode = q.Dequeue();

            if (verticalNode == null && q.Count == 0)
            {
                break;
            }

            if (verticalNode == null)
            {
                q.Enqueue(null);
                sq.Enqueue(null);
                continue;
            }

            int axis = verticalNode.verticalAxis;

            if (verticalNode.treeNode.left != null)
            {

                int leftAxis = axis - 1;

                q.Enqueue(new VerticalNode(verticalNode.treeNode.left,
                    leftAxis));
                sq.Enqueue(new VerticalNode(verticalNode.treeNode.left,
                    leftAxis));

                if (axisNodes.ContainsKey(leftAxis))
                {
                    axisNodes[leftAxis].Add(verticalNode.treeNode.left.val);
                }
                else
                {
                    axisNodes.Add(leftAxis,
                        new List<int>() { verticalNode.treeNode.left.val });
                }

                min = Math.Min(min, leftAxis);
            }

            if (verticalNode.treeNode.right != null)
            {

                int rightAxis = axis + 1;

                q.Enqueue(new VerticalNode(verticalNode.treeNode.right,
                    rightAxis));
                sq.Enqueue(new VerticalNode(verticalNode.treeNode.right,
                    rightAxis));

                if (axisNodes.ContainsKey(rightAxis))
                {
                    axisNodes[rightAxis].Add(verticalNode.treeNode.right.val);
                }
                else
                {
                    axisNodes.Add(rightAxis,
                        new List<int>() { verticalNode.treeNode.right.val });
                }

                max = Math.Max(max, rightAxis);
            }
        }

        for (int i = min; i <= max; i++) {

            List<int> verticalNodes = axisNodes[i];

            res.Add(verticalNodes[0]);
        }

        return res;
    }
}
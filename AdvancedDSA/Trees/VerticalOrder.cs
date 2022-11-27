/*
Given a binary tree, return a 2-D array with vertical order traversal of it. 
Go through the example and image for more details.

NOTE: If 2 Tree Nodes shares the same vertical level then the one with lesser depth will come first.

Problem Constraints
0 <= number of nodes <= 105

Input Format
First and only arument is a pointer to the root node of binary tree, A.

Output Format
Return a 2D array denoting the vertical order traversal of tree as shown.

Example Input
Input 1:

      6
    /   \
   3     7
  / \     \
 2   5     9
Input 2:

      1
    /   \
   3     7
  /       \
 2         9


Example Output
Output 1:

 [
    [2],
    [3],
    [6, 5],
    [7],
    [9]
 ]
Output 2:

 [
    [2],
    [3],
    [1],
    [7],
    [9]
 ]


Example Explanation
Explanation 1:

 First row represent the verical line 1 and so on.

 */
public static class Verticalorder
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
    public static List<List<int>> solve(TreeNode A)
    {
        List<List<int>> res = new List<List<int>>();
        int min = int.MaxValue, max = int.MinValue;

        Queue<VerticalNode> q = new Queue<VerticalNode> ();
        Queue<VerticalNode> sq = new Queue<VerticalNode>();
        Dictionary<int, List<int>> axisNodes = new Dictionary<int, List<int>>();
        
        q.Enqueue(new VerticalNode(A, 0));q.Enqueue(null);
        sq.Enqueue(new VerticalNode(A, 0)); sq.Enqueue(null);

        axisNodes.Add(0, new List<int>() { A.val });

        while (q.Count > 0) {

            VerticalNode verticalNode = q.Dequeue();            

            if (verticalNode == null && q.Count == 0) {
                break;
            }

            if (verticalNode == null) {
                q.Enqueue(null);
                sq.Enqueue(null);
                continue;
            }

            int axis = verticalNode.verticalAxis;

            if (verticalNode.treeNode.left != null) {

                int leftAxis = axis - 1;

                q.Enqueue(new VerticalNode(verticalNode.treeNode.left, 
                    leftAxis));
                sq.Enqueue(new VerticalNode(verticalNode.treeNode.left,
                    leftAxis));

                if (axisNodes.ContainsKey(leftAxis)) {
                    axisNodes[leftAxis].Add(verticalNode.treeNode.left.val);
                }
                else {
                    axisNodes.Add(leftAxis,
                        new List<int>() { verticalNode.treeNode.left.val });
                }

                min = Math.Min(min, leftAxis);
            }

            if(verticalNode.treeNode.right != null) {

                int rightAxis = axis + 1;

                q.Enqueue(new VerticalNode(verticalNode.treeNode.right, 
                    rightAxis));
                sq.Enqueue(new VerticalNode(verticalNode.treeNode.right,
                    rightAxis));

                if (axisNodes.ContainsKey(rightAxis)) {
                    axisNodes[rightAxis].Add(verticalNode.treeNode.right.val);
                }
                else {
                    axisNodes.Add(rightAxis, 
                        new List<int>() { verticalNode.treeNode.right.val });
                }

                max = Math.Max(max, rightAxis);
            }
        }

        for (int i = min; i <= max; i++) {

            List<int> verticalNodes = axisNodes[i];

            res.Add(verticalNodes);
        }

        return res;
    }
}
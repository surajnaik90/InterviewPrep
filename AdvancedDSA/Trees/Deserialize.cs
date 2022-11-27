/*
You are given an integer array A denoting the Level Order Traversal of the Binary Tree.

You have to Deserialize the given Traversal in the Binary Tree and return the root of the Binary Tree.

NOTE:

In the array, the NULL/None child is denoted by -1.
For more clarification check the Example Input.


Problem Constraints
1 <= number of nodes <= 105

-1 <= A[i] <= 105

Input Format
Only argument is an integer array A denoting the Level Order Traversal of the Binary Tree.

Output Format
Return the root node of the Binary Tree.

Example Input
Input 1:

 A = [1, 2, 3, 4, 5, -1, -1, -1, -1, -1, -1]
Input 2:

 A = [1, 2, 3, 4, 5, -1, 6, -1, -1, -1, -1, -1, -1]


Example Output
Output 1:

           1
         /   \
        2     3
       / \
      4   5
Output 2:

            1
          /   \
         2     3
        / \ .   \
       4   5 .   6


Example Explanation
Explanation 1:

 Each element of the array denotes the value of the node. If the val is -1 then it is the NULL/None child.
 Since 3, 4 and 5 each has both NULL child we had represented that using -1.
Explanation 2:

 Each element of the array denotes the value of the node. If the val is -1 then it is the NULL/None child.
 Since 3 has left child as NULL while 4 and 5 each has both NULL child.
 */

using System.Text;
using System.Xml.Linq;

public static class Deserialize
{
    public static TreeNode solve(List<int> A)
    {
        Queue<int> q1 = new Queue<int>();
        Dictionary<int, TreeNode> map = new Dictionary<int, TreeNode>();
        
        
        for (int i = 0; i < A.Count; i++) {
            q1.Enqueue(A[i]);
        }

        Queue<int> q2 = new Queue<int>(q1);
        q2.Dequeue();

        while(q2.Count > 0) {

            TreeNode node = null;

            int val = q1.Dequeue();

            if (val == -1) { continue; }

            if (map.ContainsKey(val)) {
                node = map[val];
            }
            else {
                map[val] = new TreeNode(val);
                node = map[val];
            }

            TreeNode leftNode = null, rightNode = null;

            int left = q2.Dequeue();
            if (map.ContainsKey(left)) {
                leftNode = map[left];
            }
            else {
                map[left] = new TreeNode(left);
                leftNode = map[left];
            }

            int right = q2.Dequeue();
            if (map.ContainsKey(right)) {
                rightNode = map[right];
            }
            else {
                map[right] = new TreeNode(right);
                rightNode = map[right];
            }
            

            if (leftNode.val != -1) {
                node.left = leftNode;
            }

            if (rightNode.val != -1) {
                node.right = rightNode;
            }
        }

        return map[A[0]];
    }
}
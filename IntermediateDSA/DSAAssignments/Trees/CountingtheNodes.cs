/*
Given the root of a tree A with each node having a certain value, 
find the count of nodes with more value than all its ancestor.

Problem Constraints
1 <= Number of Nodes <= 200000

1 <= Value of Nodes <= 2000000000

Input Format
The first and only argument of input is a tree node.

Output Format
Return a single integer denoting the count of nodes that have more value than all of its ancestors.

Example Input
Input 1:
 
     3
Input 2:

 
    4
   / \
  5   2
     / \
    3   6


Example Output
Output 1:

 1 
Output 2:

 3
Example Explanation
Explanation 1:

 There's only one node in the tree that is the valid node.
Explanation 2:

 The valid nodes are 4, 5 and 6.
 */
public static class CountingtheNodes
{
    public static int solve(TreeNode A)
    {
        if (A == null) { return 0; }

        int output = 1;

        output += calculateNodes(A, A.val);
        
        return output;
    }

    public static int calculateNodes(TreeNode treeNode, int maxAncestorValue)
    {
        if (treeNode == null || treeNode.val == -1) { return 0; }

        int output = 0, ancestorValue = maxAncestorValue;

        if(treeNode.val > ancestorValue) { 
            ancestorValue = treeNode.val;
            output += 1;
        }

        output += calculateNodes(treeNode.left, ancestorValue);

        output += calculateNodes(treeNode.right, ancestorValue);
        
        return output;
    }
}
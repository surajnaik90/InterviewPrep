/*
Given two binary trees, check if they are equal or not.

Two binary trees are considered equal if they are structurally identical and the nodes have the same value.

Problem Constraints
1 <= number of nodes <= 105

Input Format
The first argument is a root node of the first tree, A.

The second argument is a root node of the second tree, B.

Output Format
Return 0 / 1 ( 0 for false, 1 for true ) for this problem.

Example Input
Input 1:

   1       1
  / \     / \
 2   3   2   3
Input 2:

   1       1
  / \     / \
 2   3   3   3


Example Output
Output 1:

 1
Output 2:

 0

Example Explanation
Explanation 1:

 Both trees are structurally identical and the nodes have the same value.
Explanation 2:

 Values of the left child of the root node of the trees are different.
 */
public static class IdenticalBinaryTrees
{
    //Created a custom stack & have not used the language provided stack
    public static int solve(TreeNode A, TreeNode B)
    {
        if(A== null && B == null) {
            return 1;
        }

        Dictionary<char, int> value = new Dictionary<char, int>();

        int a = 1,i;

        string x = "harsh95";

        int m;
        for (i = 0; i < x.Length; i++)
        {

            if (x[i] >= 48 && x[i] <= 57)
            {
                break;
            }
        }
        m = Convert.ToInt32(x.Substring(i));

        Stack<TreeNode> stackA = new Stack<TreeNode>();
        Stack<TreeNode> stackB = new Stack<TreeNode>();

        stackA.Push(A); stackB.Push(B);

        while (stackA.Count != 0) {

            TreeNode nodeA = stackA.Pop();
            TreeNode nodeB = stackB.Pop();

            if (nodeA != nodeB) {
                return 0;
            }
            if(nodeA.right != nodeB.right) {
                return 0;
            }
            if (nodeA.left != nodeB.left) {
                return 0;
            }
            if (nodeA.right != null || nodeA.val != -1) {
                stackA.Push(nodeA.right);
                stackB.Push(nodeB.right);
            }
            if (nodeA.left != null || nodeA.val != -1) {
                stackA.Push(nodeA.left);
                stackB.Push(nodeB.left);
            }
        }
        return 1;
    }
}
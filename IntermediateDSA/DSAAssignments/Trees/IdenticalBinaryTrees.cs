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
    public static int solve(TreeNode A, TreeNode B)
    {
        if(A== null && B == null) {
            return 1;
        }

        List<int> listA = preOrderTraverse(A);
        List<int> listB = preOrderTraverse(B);

        if(listA.Count != listB.Count) {
            return 0;
        }
        else {

            for (int i = 0; i < listA.Count; i++) {

                if (listA[i] != listB[i]) {
                    return 0;
                }
            }
        }

        return 1;
    }

    public static List<int> preOrderTraverse(TreeNode node)
    {
        List<int> list = new List<int>();

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(node); list.Add(node.val);

        while (stack.Count > 0) { 
        
            TreeNode treeNode = stack.Pop();

            if (treeNode.right != null) {
                stack.Push(treeNode.right);
                list.Add(treeNode.right.val);
            }
            if (treeNode.left != null) {
                stack.Push(treeNode.left);
                list.Add(treeNode.left.val);
            }
        }

        return list;
    }
}
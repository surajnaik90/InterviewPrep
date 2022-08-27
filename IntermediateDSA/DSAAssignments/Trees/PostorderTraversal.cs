/*
Given a binary tree, return the Postorder traversal of its nodes values.

NOTE: Using recursion is not allowed.

Problem Constraints
1 <= number of nodes <= 105

Input Format
First and only argument is root node of the binary tree, A.

Output Format
Return an integer array denoting the Postorder traversal of the given binary tree.

Example Input
Input 1:

   1
    \
     2
    /
   3
Input 2:

   1
  / \
 6   2
    /
   3


Example Output
Output 1:

 [3, 2, 1]
Output 2:

 [6, 3, 2, 1]


Example Explanation
Explanation 1:

 The Preoder Traversal of the given tree is [3, 2, 1].
Explanation 2:

 The Preoder Traversal of the given tree is [6, 3, 2, 1].
 */
public static class PostorderTraversal
{
    //Created a custom stack & have not used the language provided stack
    public static List<int> solve(TreeNode A)
    {
        List<int> output = new List<int>();

        if (A == null) { return output; }

        //Declare a stack
        Dictionary<TreeNode, char> stack = new Dictionary<TreeNode, char>();
        stack.Add(A, 'l');

        int i = 0; TreeNode node; char traverseType;
        while (i >= 0) {
            //Extract the node & traversetype details
            node = stack.ElementAt(i).Key;
            traverseType = stack.ElementAt(i).Value;

            switch (traverseType) {

                case 'l':
                    if (node.left == null || node.left.val == -1) {
                        stack[node] = 'r';
                        output.Add(node.val);
                        continue;
                    }
                    else {
                        stack.Add(node.left, 'l');
                        i++;
                    }
                    break;

                case 'r':
                    if (node.right == null || node.right.val == -1) {
                        stack[node] = 'd';
                        output.Add(node.val);
                        continue;
                    }
                    else {
                        stack.Add(node.right, 'l');
                        i++;
                    }
                    break;

                case 'd':

                    output.Add(node.val);
                    if (stack.Count == 1) {
                        return output;
                    }
                    stack.Remove(node); i--;

                    node = stack.ElementAt(i).Key;
                    traverseType = stack.ElementAt(i).Value;

                    if (traverseType == 'l') {
                        stack[node] = 'r';
                    }
                    else if (traverseType == 'r') {
                        stack[node] = 'd';
                    }
                    break;
            }

        }

        return output;
    }
}
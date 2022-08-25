/*
 * https://leetcode.com/problems/binary-tree-postorder-traversal/
Given the root of a binary tree, return the postorder traversal of its nodes' values.

Example 1:

Input: root = [1,null,2,3]
Output: [3,2,1]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [1]
Output: [1] 

Constraints:

The number of the nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100tree is in the range [0, 100].
-100 <= Node.val <= 100
 */


public static class PostorderTraversal145
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
        while (i >= 0)
        {
            //Extract the node & traversetype details
            node = stack.ElementAt(i).Key;
            traverseType = stack.ElementAt(i).Value;

            switch (traverseType)
            {

                case 'l':
                    if (node.left == null)
                    {
                        stack[node] = 'r';
                        continue;
                    }
                    else
                    {
                        stack.Add(node.left, 'l');
                        i++;
                    }
                    break;

                case 'r':
                    if (node.right == null)
                    {
                        stack[node] = 'd';
                        continue;
                    }
                    else
                    {
                        stack.Add(node.right, 'l');
                        i++;
                    }
                    break;

                case 'd':

                    output.Add(node.val);
                    if (stack.Count == 1)
                    {
                        return output;
                    }
                    stack.Remove(node); i--;

                    node = stack.ElementAt(i).Key;
                    traverseType = stack.ElementAt(i).Value;

                    if (traverseType == 'l')
                    {
                        stack[node] = 'r';
                    }
                    else if (traverseType == 'r')
                    {
                        stack[node] = 'd';
                    }
                    break;
            }

        }

        return output;
    }
}
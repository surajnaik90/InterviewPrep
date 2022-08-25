/*
 * https://leetcode.com/problems/maximum-depth-of-binary-tree/
 Given the root of a binary tree, return its maximum depth.

A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: 3
Example 2:

Input: root = [1,null,2]
Output: 2 

Constraints:

The number of nodes in the tree is in the range [0, 104].
-100 <= Node.val <= 100
 */
public static class MaximumDepthTree
{
    //Created a custom stack & have not used the language provided stack
    public static int solve(TreeNode A)
    {
        int output = 0;

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

                    output = Math.Max(output, stack.Count);

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
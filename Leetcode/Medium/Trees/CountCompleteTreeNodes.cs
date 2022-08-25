/*
 * https://leetcode.com/problems/count-complete-tree-nodes/
Given the root of a complete binary tree, return the number of the nodes in the tree.

According to Wikipedia, every level, except possibly the last, is completely filled in a complete binary tree, 
and all nodes in the last level are as far left as possible. It can have between 1 and 2h nodes inclusive at the last level h.

Design an algorithm that runs in less than O(n) time complexity. 

Example 1:

Input: root = [1,2,3,4,5,6]
Output: 6
Example 2:

Input: root = []
Output: 0
Example 3:

Input: root = [1]
Output: 1
 

Constraints:

The number of nodes in the tree is in the range [0, 5 * 104].
0 <= Node.val <= 5 * 104
The tree is guaranteed to be complete.
 */
public static class CountCompleteTreeNodes222
{
    //Created a custom stack & have not used the language provided stack
    public static int solve(TreeNode A)
    {
        int output = 0;

        if (A == null) { return output; }

        //Declare a stack
        Dictionary<TreeNode, char> stack = new Dictionary<TreeNode, char>();
        stack.Add(A, 'l'); output++;

        int i = 0; TreeNode node; char traverseType;

        while (i >= 0)
        {

            //Extract the node & traversetype details
            node = stack.ElementAt(i).Key;
            traverseType = stack.ElementAt(i).Value;

            switch (traverseType)
            {

                case 'l':
                    if (node.left == null || node.left.val == -1)
                    {
                        stack[node] = 'r';
                        continue;
                    }
                    else
                    {
                        stack.Add(node.left, 'l');
                        i++; output++;
                    }
                    break;

                case 'r':
                    if (node.right == null || node.right.val == -1)
                    {
                        stack[node] = 'd';
                        continue;
                    }
                    else
                    {
                        stack.Add(node.right, 'l');
                        i++; output++;
                    }
                    break;

                case 'd':
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
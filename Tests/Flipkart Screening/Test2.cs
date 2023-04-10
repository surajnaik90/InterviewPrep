/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
using System.Collections.Generic;
class Solution
{

    private List<int> flattenedList = new List<int>();

    public TreeNode flatten(TreeNode A)
    {

        //Create a pre-order list
        PreOrderTraversal(A);

        //Create a linked list
        TreeNode head = new TreeNode(A.val);

        TreeNode tempNode = head;
        for (int i = 1; i < flattenedList.Count; i++)
        {

            TreeNode newNode = new TreeNode(flattenedList[i]);
            tempNode.right = newNode;
            tempNode = newNode;
        }

        return head;
    }

    //Create a pre-order traversal - flattened list using recursion
    public void PreOrderTraversal(TreeNode node)
    {

        if (node == null)
        {
            return;
        }

        flattenedList.Add(node.val);

        if (node.left != null)
        {
            PreOrderTraversal(node.left);
        }

        if (node.right != null)
        {
            PreOrderTraversal(node.right);
        }

        return;
    }
}
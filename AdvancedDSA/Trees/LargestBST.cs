/*
 You are given a Binary Tree A with N nodes.

Write a function that returns the size of the largest subtree, which is also a Binary Search Tree (BST).

If the complete Binary Tree is BST, then return the size of the whole tree.

NOTE:

The largest subtree is the subtree with the most number of nodes.

Problem Constraints
1 <= N <= 105

Input Format
First and only argument is an pointer to root of the binary tree A.

Output Format
Return an single integer denoting the size of the largest subtree which is also a BST.

Example Input
Input 1:

     10
    / \
   5  15
  / \   \ 
 1   8   7
Input 2:

     5
    / \
   3   8
  / \ / \
 1  4 7  9


Example Output
Output 1:

 3
Output 2:

 7

Example Explanation
Explanation 1:

 Largest BST subtree is
                            5
                           / \
                          1   8
Explanation 2:

 Given binary tree itself is BST.
 */
namespace MAANG.AdvancedDSA.Trees
{
    public class LargestBST
    {
        public static int maxCount = int.MinValue;
        public static int solve(TreeNode A)
        {
            findMaxCount(A);

            return maxCount;
        }

        public static int findMaxCount(TreeNode node)
        {
            int lcount = 0, rcount = 0, size = 0;
            bool isL = false, isR = false;

            if(node.val == -1) {
                return 0;
            }

            if(node.left == null && node.right == null) {
                maxCount = Math.Max(maxCount, 1);
                return 1;
            }

            if(node.left != null) {

                if(node.left.val <= node.val || node.left.val == -1) {
                    isL = true;
                    lcount += findMaxCount(node.left);
                    if(lcount == 0) {
                        isL = false;
                    }
                }
            }
            else {
                isL = true;
            }

            if (node.right != null) { 
                if(node.right.val > node.val || node.right.val == -1) {
                    isR = true;
                    rcount += findMaxCount(node.right);
                    if(rcount == 0) {
                        isR = false;
                    }
                }
            }
            else {
                isR = true;
            }

            if (isL && isR) {
                size = 1 + lcount + rcount;
                maxCount = Math.Max(maxCount, size);
                return size;
            }
            else {
                return 0;
            }
        }
    }
}
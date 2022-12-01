/*
Given a binary search tree A, where each node contains a positive integer, and an integer B, 
you have to find whether or not there exist two different nodes X and Y such that X.value + Y.value = B.

Return 1 to denote that two such nodes exist. Return 0, otherwise.

Problem Constraints
1 <= size of tree <= 100000

1 <= B <= 109

Input Format
First argument is the head of the tree A.

Second argument is the integer B.

Output Format
Return 1 if such a pair can be found, 0 otherwise.

Example Input
Input 1:

         10
         / \
        9   20

B = 19
Input 2:

 
          10
         / \
        9   20

B = 40

Example Output
Output 1:

 1
Output 2:

 0

Example Explanation
Explanation 1:

 10 + 9 = 19. Hence 1 is returned.
Explanation 2:

 No such pair exists
 */
using System.Collections;

public static class TwoSumBST
{
    public static int solve(TreeNode A, int B)
    {
        HashSet<int> numbers = new HashSet<int>();       

        if (isFound(A, B, numbers)) {
            return 1;
        }
        else {
            return 0;
        }
    }

    public static bool isFound(TreeNode node, int B, HashSet<int> numbers)
    {
        if (node == null) { return false; }

        if (!numbers.Contains(node.val)) {
            numbers.Add(node.val);
        }

        bool isNodesFound = false, isLeftFound = false, isRightFound = false;
        int val;

        val = B - node.val;

        if (numbers.Contains(val) && val != node.val) {
            isNodesFound = true;
            return isNodesFound;
        }

        isLeftFound = isFound(node.left, B, numbers);

        isRightFound = isFound(node.right, B, numbers);

        return isLeftFound || isRightFound;
    }
}
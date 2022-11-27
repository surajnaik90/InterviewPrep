/*
Given a binary tree, return the zigzag level order traversal of its nodes values. 
(ie, from left to right, then right to left for the next level and alternate between).

Problem Constraints
1 <= number of nodes <= 105

Input Format
First and only argument is root node of the binary tree, A.

Output Format
Return a 2D integer array denoting the zigzag level order traversal of the given binary tree.

Example Input
Input 1:

    3
   / \
  9  20
    /  \
   15   7
Input 2:

   1
  / \
 6   2
    /
   3


Example Output
Output 1:

 [
   [3],
   [20, 9],
   [15, 7]
 ]
Output 2:

 [ 
   [1]
   [2, 6]
   [3]
 ]


Example Explanation
Explanation 1:

 Return the 2D array. Each row denotes the zigzag traversal of each level.
 */

using System.Text;
using System.Xml.Linq;

public static class ZigZag
{
    public static List<List<int>> solve(TreeNode A)
    {
        List<List<int>> res = new List<List<int>>();
        List<TreeNode> serializedNodes = new List<TreeNode>();
        Dictionary<int, int> map = new Dictionary<int, int>();

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(A); q.Enqueue(null);
        serializedNodes.Add(A); serializedNodes.Add(null);

        int index = -1, level = 1;
        while (q.Count > 0) {

            index++;

            TreeNode node = q.Dequeue();

            if(node == null & q.Count == 0) {
                break;
            }

            if(node == null) {
                q.Enqueue(null);
                serializedNodes.Add(null);
                map.Add(level, index);
                level++;
                continue;
            }

            if (node.left != null) {
                q.Enqueue(node.left);
                serializedNodes.Add(node.left);
            }

            if (node.right != null) {
                q.Enqueue(node.right);
                serializedNodes.Add(node.right);
            }
        }
        map.Add(level, index);

        int startIndex = 0, endIndex = 0, prevEndIndex = -1;

        for (int i = 0; i < map.Count; i++) {

            List<int> lst = new List<int>();
            int lvl = map.ElementAt(i).Key;
            endIndex = map.ElementAt(i).Value;
            startIndex = prevEndIndex + 1;
            prevEndIndex = endIndex;

            if (lvl % 2 != 0) {
                while (startIndex < endIndex) {
                    lst.Add(serializedNodes[startIndex].val);
                    startIndex++;
                }
            }
            else {
                endIndex = endIndex - 1;
                while (endIndex >= startIndex) { 
                    lst.Add(serializedNodes[endIndex].val);
                    endIndex--;
                }
                
            }
            res.Add(lst);
        }
        
        return res;
    }
}
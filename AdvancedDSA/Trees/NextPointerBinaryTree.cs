/*
Given a binary tree,

Populate each next pointer to point to its next right node. 
If there is no next right node, the next pointer should be set to NULL.

Initially, all next pointers are set to NULL.

Assume perfect binary tree and try to solve this in constant extra space.

Problem Constraints
1 <= Number of nodes in binary tree <= 100000

0 <= node values <= 10^9

Input Format
First and only argument is head of the binary tree A.

Output Format
Return the head of the binary tree after the changes are made.

Example Input
Input 1:
 
     1
    /  \
   2    3
Input 2:

 
        1
       /  \
      2    5
     / \  / \
    3  4  6  7


Example Output
Output 1:

 
        1 -> NULL
       /  \
      2 -> 3 -> NULL
Output 2:

 
         1 -> NULL
       /  \
      2 -> 5 -> NULL
     / \  / \
    3->4->6->7 -> NULL


Example Explanation
Explanation 1:

Next pointers are set as given in the output.
Explanation 2:

Next pointers are set as given in the output.
 */

using System.Text;
using System.Xml.Linq;
public class TreeLinkNode
{
    public int val;
    public TreeLinkNode left;
    public TreeLinkNode right, next;
    public TreeLinkNode(int x)
    {
        this.val = x;
        this.left = this.right = null;
        this.next = null;
    }
}
public static class NextPointerBinaryTree
{
    
    public static void solve1(TreeLinkNode root)
    {
        Queue<TreeLinkNode> tmpQueue = new Queue<TreeLinkNode>();
        Queue<TreeLinkNode> mainQ = new Queue<TreeLinkNode>();

        tmpQueue.Enqueue(root); mainQ.Enqueue(root);
        tmpQueue.Enqueue(null); mainQ.Enqueue(null);

        while(tmpQueue.Count > 0) {

            TreeLinkNode node = tmpQueue.Dequeue();

            if(node == null && tmpQueue.Count == 0) {
                break;
            }

            if (node == null) {
                tmpQueue.Enqueue(null);
                mainQ.Enqueue(null);
            }
            else {

                if (node.left != null) {
                    tmpQueue.Enqueue(node.left);
                    mainQ.Enqueue(node.left);
                }

                if (node.right != null) {
                    tmpQueue.Enqueue(node.right);
                    mainQ.Enqueue(node.right);
                }
            }
        }

        while(mainQ.Count > 0) {

            TreeLinkNode node = mainQ.Dequeue();

            while (node != null) {

                TreeLinkNode curr = node;

                node = mainQ.Dequeue();

                curr.next = node;
            }
        }
    }

    //Can be solved in O(1) space complexity as well
    public static void solve2(TreeLinkNode root)
    {




    }
}
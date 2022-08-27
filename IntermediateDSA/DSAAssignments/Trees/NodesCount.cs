/*
You are given the root node of a binary tree A. You have to find the number of nodes in this tree.

Problem Constraints
1 <= Number of nodes in the tree <= 105

0 <= Value of each node <= 107

Input Format
The first and only argument is a tree node A.

Output Format
Return an integer denoting the number of nodes of the tree. 

Example Input
Input 1:

 Values =  1 
          / \     
         4   3                        
Input 2:

 
 Values =  1      
          / \     
         4   3                       
        /         
       2                                     


Example Output
Output 1:

 3 
Output 2:

 4 

Example Explanation
Explanation 1:

Clearly, there are 3 nodes 1, 4 and 3.
Explanation 2:

Clearly, there are 4 nodes 1, 4, 3 and 2.
 */
public static class NodesCount
{
    //Created a custom stack & have not used the language provided stack
    public static int solve(TreeNode A)
    {
        int output = 0;

        if (A == null) { return output; }

        //Declare a stack
        Dictionary<TreeNode, char> stack = new Dictionary<TreeNode, char>();
        stack.Add(A, 'l');output++;

        int i = 0; TreeNode node; char traverseType;
        
        while (i >= 0) {

            //Extract the node & traversetype details
            node = stack.ElementAt(i).Key;
            traverseType = stack.ElementAt(i).Value;

            switch (traverseType) {

                case 'l':
                    if (node.left == null || node.left.val == -1) {
                        stack[node] = 'r';
                        continue;
                    }
                    else {
                        stack.Add(node.left, 'l');                         
                        i++; output++;
                    }
                    break;

                case 'r':
                    if (node.right == null || node.right.val == -1) {
                        stack[node] = 'd';
                        continue;
                    }
                    else {
                        stack.Add(node.right, 'l');
                        i++; output++;
                    }
                    break;

                case 'd':
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
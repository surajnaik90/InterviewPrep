package Trees;

import com.sun.source.tree.Tree;

public class LargestBST {

    public static int ans = 0;
    public static int solve(TreeNode A) {

        ans = 0;

        int output = findLargestBST(A);
        output = Math.max(output,ans);

        return output;
    }
    public static int findLargestBST(TreeNode node){

        if(node.left == null && node.right == null) {
            return 1;
        }

        int left = Integer.MIN_VALUE, right = Integer.MIN_VALUE;

        if(node.left != null) {

            int tLeft = findLargestBST(node.left);

            if(node.left.val <= node.val) {
                left = tLeft;
                ans = Math.max(ans, left);
            }
            else {
                left = 0;
            }
        }

        if(node.right != null) {

            int tright = findLargestBST(node.right);

            if(node.right.val > node.val) {
                right = tright;
                ans = Math.max(ans, right);
            }
            else {
                right = 0;
            }
        }

        int res = 0;
        if(left == Integer.MIN_VALUE && right != 0) {
            res = right + 1;
            ans = Math.max(ans, res);
            return res;
        }
        else if(right == Integer.MIN_VALUE && left != 0) {
            res = left + 1;
            ans = Math.max(ans, res);
            return  res;
        }
        else if(left != 0 && right != 0) {
            res = left + right + 1;
            ans = Math.max(ans, res);
            return res;
        }
        else {
            return 0;
        }
    }
}
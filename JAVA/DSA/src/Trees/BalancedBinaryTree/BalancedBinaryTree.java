package Trees.BalancedBinaryTree;

import Trees.TreeNode;

import java.util.Arrays;
import java.util.List;

public class BalancedBinaryTree {
    public static int isBalanced(TreeNode A) {

        List<Object> ans = compute(A);

        if((Boolean)ans.get(0) == true){
            return 1;
        }
        else {
            return 0;
        }
    }

    public static List<Object> compute(TreeNode node) {

        if(node.left == null && node.right == null) {
            return Arrays.asList(true, 1);
        }

        List<Object> left, right;

        if(node.left != null) {
            left = compute(node.left);
        }
        else {
            left = Arrays.asList(true,0);
        }

        if((Boolean)left.get(0) == false) {
            return Arrays.asList(false,0);
        }

        if(node.right != null) {
            right = compute(node.right);
        }
        else {
            right = Arrays.asList(true,0);
        }

        if((Boolean)right.get(0) == false) {
            return Arrays.asList(false,0);
        }

        boolean isValid;
        int depth = 0;

        //Compute the difference, to find out the validity
        int diff = Math.abs((Integer)left.get(1) - (Integer)right.get(1));

        if(diff <= 1){
            isValid = true;
        }
        else {
            isValid = false;
        }
        //Compute the depth
        depth = Math.max((Integer)left.get(1), (Integer)right.get(1)) + 1;

        return Arrays.asList(isValid, depth);
    }
}
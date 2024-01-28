package Trees.DiameterBinaryTree;

import Trees.TreeNode;

public class Diameter {
    public static int diameter = Integer.MIN_VALUE;
    public static int solve(TreeNode A) {

        diameter = Integer.MIN_VALUE;

        getDiameter(A);

        return diameter;
    }
    public static int getDiameter(TreeNode node) {

        if(node == null) { return 0; }

        int left = 0, right = 0;

        left = getDiameter(node.left);

        right = getDiameter(node.right);

        diameter = Math.max(left + right, diameter);

        return 1 + Math.max(left,right);
    }
}

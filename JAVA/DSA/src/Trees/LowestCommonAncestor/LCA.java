package Trees.LowestCommonAncestor;

import Trees.TreeNode;

public class LCA {

    public static int ans  = Integer.MIN_VALUE;
    public static int lca(TreeNode A, int B, int C) {

        ans  = Integer.MIN_VALUE;

        computeLCA(A, B, C, 1);

        if(ans == Integer.MIN_VALUE) {
            return 1;
        }
        else {
            return ans;
        }
    }
    public static void computeLCA(TreeNode node, int B, int C, int level) {

        if(node == null) { return; }

        int l = 0, r = 0;

        if(node.left != null) {
            computeLCA(node.left, B, C, level+1);
            l = node.left.val;
        }

        if(node.right != null) {
            computeLCA(node.right,B,C, level+1);
            r = node.right.val;
        }

        if((l == B && r == C) || (l == C && r == B)) {
            ans = Math.max(ans, level);
        }

        return;
    }
}

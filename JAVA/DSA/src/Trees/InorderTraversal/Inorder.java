package Trees.InorderTraversal;

import Trees.TreeNode;

import java.util.ArrayList;

public class Inorder {

    public static ArrayList<Integer> ans;
    public static ArrayList<Integer> inorderTraversal(TreeNode A) {

        ans = new ArrayList<>();

        inorder(A);

        return ans;
    }

    public static void inorder(TreeNode node) {

        if(node == null) { return; }

        inorder(node.left);

        ans.add(node.val);

        inorder(node.right);

        return;
    }
}
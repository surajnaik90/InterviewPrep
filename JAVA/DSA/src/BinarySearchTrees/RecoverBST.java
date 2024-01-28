package BinarySearchTrees;
import java.util.ArrayList;
import java.util.Collections;

public class RecoverBST {
    public class TreeNode {
          int val;
          TreeNode left;
          TreeNode right;
          TreeNode(int x) {
           val = x;
           left=null;
           right=null;
          }
    }

    public static ArrayList<Integer> output;

    public static TreeNode prev, first, second;

    public ArrayList<Integer> recoverTree(TreeNode A) {

        output = new ArrayList<>();
        prev = null; first = null; second = null;

        findNode(A);

        output.add(first.val);
        output.add(second.val);

        Collections.sort(output);

        return output;
    }

    public static void findNode(TreeNode node) {

        if(node == null) { return; }

        findNode(node.left);

        if(prev != null && prev.val > node.val) {

            if(first == null) {
                first = prev; second = node;
            }
            else {
                second = node;
            }
        }

        prev = node;
        findNode(node.right);
    }
}
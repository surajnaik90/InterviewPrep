package Trees.BalancedBinaryTree;

import Trees.Deserialize;
import Trees.LargestBST;
import Trees.TreeNode;

import java.util.ArrayList;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) {

        ArrayList<Integer> i1 = new ArrayList<>(
                Arrays.asList(1,2,3,-1,-1,-1,-1));

        TreeNode A = Deserialize.solve(i1);

        int ans = BalancedBinaryTree.isBalanced(A);

        System.out.println("Input 1 ans: " + ans);


        ArrayList<Integer> i2 = new ArrayList<>(
                Arrays.asList(1,2,-1,3,-1,-1,-1));

        A = Deserialize.solve(i2);

        ans = BalancedBinaryTree.isBalanced(A);

        System.out.println("Input 2 ans: " + ans);


        ArrayList<Integer> i3 = new ArrayList<>(
                Arrays.asList(12,8,9,-1,-1,-1,-1));

        A = Deserialize.solve(i3);

        ans = BalancedBinaryTree.isBalanced(A);

        System.out.println("Input 3 ans: " + ans);
    }
}

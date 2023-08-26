package Trees.DiameterBinaryTree;

import Trees.Deserialize;
import Trees.LowestCommonAncestor.LCA;
import Trees.TreeNode;

import java.util.ArrayList;
import java.util.Arrays;

public class Main {

    public static void main(String[] args) {

        ArrayList<Integer> i1 = new ArrayList<>(
                Arrays.asList(1,2,3,-1,-1,-1,-1));

        TreeNode A = Deserialize.solve(i1);

        int ans = Diameter.solve(A);

        System.out.println("Input 1 ans: " + ans);


        ArrayList<Integer> i2 = new ArrayList<>(
                Arrays.asList(1,2,3,4,5,-1,-1,-1,-1,-1,-1));

        A = Deserialize.solve(i2);

        ans = Diameter.solve(A);

        System.out.println("Input 2 ans: " + ans);

        ArrayList<Integer> i3 = new ArrayList<>(
                Arrays.asList(1,2,3,4,5,7,8,-1,-1,-1,-1,-1,-1,-1,-1));

        A = Deserialize.solve(i3);

        ans = Diameter.solve(A);

        System.out.println("Input 3 ans: " + ans);
    }
}

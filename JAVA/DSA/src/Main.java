import Backtracking.Permutations;

import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        System.out.println("Hello world!");

        String A = "Anshuman";
        String B = "Antihuman";

        //int ans = LongestCommonSubsequence.solve(A,B);

        //int ans = EditDistance.minDistance(A,B);

        //ArrayList<Integer> i1 = new ArrayList<>();
        //i1.add(1); i1.add(2); i1.add(3);
        //int b1 = 4;

        //int ans = CoinSumInfinite.coinchange2(i1, b1);

        //int ans  = NDigitNumbers.solve(1000,5000);

        ArrayList<Integer> i1 = new ArrayList<>();
        i1.add(1);

        ArrayList<ArrayList<Integer>> ans = Permutations.permute(i1);

        System.out.println(ans);
    }
}
package Graphs.RottenOranges;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {

        int ans = 0;

        ArrayList<ArrayList<Integer>> i1 = new ArrayList<>();
        ArrayList<Integer> row0 = new ArrayList<>();
        row0.add(2); row0.add(1); row0.add(1);
        i1.add(row0);
        ArrayList<Integer> row1 = new ArrayList<>();
        row1.add(1); row1.add(1); row1.add(0);
        i1.add(row1);
        ArrayList<Integer> row2 = new ArrayList<>();
        row2.add(0); row2.add(1); row2.add(1);
        i1.add(row2);

        ans = Solution.solve(i1);

        System.out.println(ans);
    }
}

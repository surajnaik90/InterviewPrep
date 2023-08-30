package Graphs.Bipartite;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {

        int A = 1; ArrayList<Integer> i11;
        ArrayList<ArrayList<Integer>> i1;

        i1 = new ArrayList<>();
        i11 = new ArrayList<Integer>();
        i11.add(0); i11.add(1);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(1); i11.add(2);
        i1.add(i11);

        int ans  =BipartiteGraph.solve(2, i1);

        System.out.println(ans);
    }
}

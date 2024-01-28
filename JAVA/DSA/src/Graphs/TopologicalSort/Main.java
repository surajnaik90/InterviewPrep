package Graphs.TopologicalSort;

import Graphs.Bipartite.BipartiteGraph;

import java.util.ArrayList;
public class Main {
    public static void main(String[] args){

        int A = 6; ArrayList<Integer> i11;
        ArrayList<ArrayList<Integer>> i1;
        ArrayList<Integer> ans = null;

        i1 = new ArrayList<>();
        i11 = new ArrayList<Integer>();
        i11.add(6); i11.add(3);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(6); i11.add(1);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(5); i11.add(1);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(5); i11.add(2);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(3); i11.add(4);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(4); i11.add(2);
        i1.add(i11);

        ans  = Solution.solve(A, i1);

        System.out.println(ans);


        A = 8;
        i1 = new ArrayList<>();
        i11 = new ArrayList<Integer>();
        i11.add(1); i11.add(4);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(1); i11.add(2);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(4); i11.add(2);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(4); i11.add(3);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(3); i11.add(2);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(5); i11.add(2);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(3); i11.add(5);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(8); i11.add(2);
        i1.add(i11);
        i11 = new ArrayList<Integer>();
        i11.add(8); i11.add(6);
        i1.add(i11);

        ans  = Solution.solve(A, i1);

        System.out.println(ans);
    }
}
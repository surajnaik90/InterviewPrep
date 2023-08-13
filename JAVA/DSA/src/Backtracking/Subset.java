package Backtracking;
import java.util.*;

public class Subset {
    public static HashSet<ArrayList<Integer>> map = new HashSet<>();
    public static  ArrayList<ArrayList<Integer>> result = new ArrayList<>();
    public static ArrayList<ArrayList<Integer>> subsets(ArrayList<Integer> A) {

        map.clear();
        result.clear();

        Queue<Integer> q = new LinkedList<>();

        Collections.sort(A); q.addAll(A);

        ArrayList<Integer> init = new ArrayList<>();
        result.add(init);

        computeSubsets(q,new ArrayList<>());

        return result;
    }

    public static void computeSubsets(Queue<Integer> q, ArrayList<Integer> subset) {

        if(q.size() == 0) { return; }

        Queue<Integer> newQ = new LinkedList<>(q);

        for (int i = 0; i < q.size(); i++) {

            ArrayList<Integer> newSubset = new ArrayList<>(subset);

            int element = newQ.peek();

            //For the subset formed
            newSubset.add(element);
            if(!map.contains(newSubset)){
                map.add(newSubset);
                result.add(newSubset);
            }

            newQ.remove();

            computeSubsets(newQ, newSubset);
        }
    }
}
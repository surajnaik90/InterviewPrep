package Backtracking;

import java.util.*;

public class Permutations {

    static ArrayList<ArrayList<Integer>> permutations = new ArrayList<>();
    public static ArrayList<ArrayList<Integer>> permute(ArrayList<Integer> A) {

        permutations.clear();

        Queue<Integer> mainQ = new LinkedList<>();
        Stack<Integer> stack = new Stack<>();

        for(int i = 0; i < A.size(); i++) {
            mainQ.add(A.get(i));
        }

        compute(mainQ, stack);

        return permutations;
    }

    public static void compute(Queue<Integer> mQ, Stack<Integer> stk){

        if(mQ.size() == 0) {

            ArrayList<Integer> list = new ArrayList<>();

            Iterator iterator = stk.iterator();
            while(iterator.hasNext()) {
                list.add((Integer) iterator.next());
            }
            permutations.add(list);

            return;
        }

        for(int i = 0; i < mQ.size(); i++) {

            stk.push(mQ.peek());

            Queue<Integer> newQ = new LinkedList<>(mQ);
            newQ.remove();

            compute(newQ, stk);

            if(!stk.isEmpty()){
                stk.pop();
            }

            mQ.add(mQ.remove());
        }

        return;
    }
}
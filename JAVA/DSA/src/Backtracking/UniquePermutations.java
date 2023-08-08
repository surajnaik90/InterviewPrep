package Backtracking;

import java.util.*;

public class UniquePermutations {

    public static HashSet<ArrayList> permutations = new HashSet<>();
    public static ArrayList<ArrayList<Integer>> permute(ArrayList<Integer> A) {

        ArrayList<ArrayList<Integer>> ans = new ArrayList<>();
        Queue<Integer> q = new LinkedList<>();
        Stack<Integer> stk = new Stack<>();
        permutations.clear();

        for (int i = 0; i < A.size(); i++) {
            q.add(A.get(i));
        }

        compute(q,stk);

        for (ArrayList list: permutations) {
            ans.add(list);
        }

        return ans;
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
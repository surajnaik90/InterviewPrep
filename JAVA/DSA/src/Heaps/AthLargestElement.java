package Heaps;

import java.util.*;

public class AthLargestElement {
    public static ArrayList<Integer> solve(int A, ArrayList<Integer> B) {

        ArrayList<Integer> output = new ArrayList<>();
        PriorityQueue<Integer> pq = new PriorityQueue<>();

        for (int i = 0; i < B.size(); i++) {

            pq.add(B.get(i));

            if(pq.size() < A) {
                output.add(-1);
            }
            else if(pq.size() == A) {
                output.add(pq.peek());
            }
            else {
                pq.remove();
                output.add(pq.peek());
            }
        }

        return output;
    }
}
package Heaps;

import java.util.ArrayList;
import java.util.PriorityQueue;

public class AthLargestElement {

    public static PriorityQueue<Integer> pq;

    public static ArrayList<Integer> result = new ArrayList<>();

    public static ArrayList<Integer> solve(int A, ArrayList<Integer> B) {

        pq = new PriorityQueue<>(A);

        for (int i = 0; i < A -1 ; i++) {
            pq.add(B.get(i));
        }

        for (int i = 0; i < B.size(); i++) {

            if(i < A - 1) {
                result.add(-1);
                continue;
            }

            pq.add(B.get(i));

            result.add(pq.remove());
        }

        return result;
    }
}
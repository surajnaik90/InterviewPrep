package Heaps;
import java.util.ArrayList;
import java.util.PriorityQueue;

public class KPlacesApart {
    public ArrayList<Integer> solve(ArrayList<Integer> A, int B) {

        ArrayList<Integer> list = new ArrayList<>();
        PriorityQueue<Integer> pq = new PriorityQueue<>();

        for (int i = 0; i < A.size(); i++) {
            pq.add(A.get(i));
        }

        while(!pq.isEmpty()){
            list.add(pq.remove());
        }

        return list;
    }
}
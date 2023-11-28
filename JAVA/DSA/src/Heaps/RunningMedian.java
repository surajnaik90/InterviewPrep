package Heaps;
import java.util.ArrayList;
import java.util.Collection;
import java.util.PriorityQueue;

public class RunningMedian {
    public static ArrayList<Integer> solve(ArrayList<Integer> A) {

        ArrayList<Integer> output = new ArrayList<>();

        ArrayList<Integer> temp = new ArrayList<>();




        PriorityQueue<Integer> pq = new PriorityQueue<>();

        int mid = 0;
        for (int i = 0; i < A.size(); i++) {

            pq.add(A.get(i));

            temp.add(pq.remove());
            if(temp.size() % 2 == 0) {
                mid = (temp.size() / 2) - 1;
            }
            else {
                mid = temp.size() / 2;
            }

            output.add(temp.get(mid));
        }

        return output;
    }
}
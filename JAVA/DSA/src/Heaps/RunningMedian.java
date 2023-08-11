package Heaps;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Iterator;
import java.util.PriorityQueue;

public class RunningMedian {
    public static ArrayList<Integer> solve(ArrayList<Integer> A) {

        ArrayList<Integer> ans = new ArrayList<>();
        PriorityQueue<Integer> minHeap = new PriorityQueue<>();

        for (int i = 0; i < A.size(); i++) {
            minHeap.add(A.get(i));
        }

        int endIndex, index = 0;
        for (int i = 0; i < A.size(); i++) {

            minHeap.add(A.get(i));

            if(minHeap.size() % 2 == 0) {
                endIndex = (minHeap.size() / 2) - 1;
            }
            else {
                endIndex = (minHeap.size() / 2);
            }

            index = 0;
            Iterator iterator = minHeap.iterator();
            while(index <= endIndex){
                if(index == endIndex){
                    ans.add((Integer)iterator.next());
                }
                if(iterator.hasNext()){
                    iterator.next();
                }
                index++;
            }
        }
        return ans;
    }
}
package StacksQueues;

import java.util.*;

public class SlidingWindowMaximum {

    //Priority Queue - It gives TLE
    public static ArrayList<Integer> slidingMaximum(final List<Integer> A, int B) {

        ArrayList<Integer> ans = new ArrayList<>();
        PriorityQueue<Integer> maxPq = new PriorityQueue<>(Collections.reverseOrder());
        int max = Integer.MIN_VALUE;

        if(B > A.size()){
            ans.add(max);
            return ans;
        }

        for (int i = 0; i < B; i++) {
            maxPq.add(A.get(i));
            max = Math.max(max,A.get(i));
        }

        ans.add(max);
        for (int i = 0; i < A.size() - B ; i++) {

            //Remove the first element in the window
            maxPq.remove(A.get(i));

            //Append the last element to the window
            maxPq.add(A.get(i+B));

            ans.add(maxPq.peek());
        }

        return ans;
    }
}
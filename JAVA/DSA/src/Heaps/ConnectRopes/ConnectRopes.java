package Heaps.ConnectRopes;
import java.util.*;
public class ConnectRopes {
    public static int solve(ArrayList<Integer> A) {

        int ans = 0, outerSum = 0, innerSum = 0, poppedElement = 0;
        PriorityQueue<Integer> minPq = new PriorityQueue<>();

        if(A.size() == 1) {
            return A.get(0);
        }

        ans += A.get(0) + A.get(1);
        for (int i = 2; i < A.size(); i++) {
            minPq.add(A.get(i));
        }

        while(minPq.size() > 0) {

            poppedElement = minPq.remove();
            outerSum = ans + poppedElement;

            int peekedItem = 0;

            if(minPq.peek() != null) {
                peekedItem = minPq.peek();
            }
            innerSum = poppedElement + peekedItem;

            if(outerSum <= innerSum) {
                ans += outerSum;
            }
            else {
                ans += innerSum;
                if(minPq.peek() != null) {
                    minPq.remove();
                }
            }
        }

        return ans;
    }
}
package DynamicProgramming.BuySellStockI;
import java.util.*;
public class BuySellStock {

    public static int ans = 0;
    public static int maxProfit(final List<Integer> A) {

        if(A.size() == 0) { return 0;}

        ans = 0;

        compute(1, A.get(0), A);

        return ans;
    }

    public static void compute(int index, int cost, List<Integer> list) {

        //Simple concept: On any given day either you buy it or sell it or do nothing

        if(index >= list.size()) { return; }

        //Buy the stock
        compute(index+1, list.get(index),list);

        //sell the stock - in the real world this is actually a computation to check whether
        // if sold how much profit are we getting - Think in that line
        int profit = list.get(index) - cost;
        ans = Math.max(ans, profit);

        //Do nothing - just move on
        compute(index+1, cost,list);

        return;
    }

    //Very Simple Solution
    public static int computeII(List<Integer> list) {

        int ans = Integer.MIN_VALUE;
        int min = Integer.MAX_VALUE;

        for (int i = 0; i < list.size(); i++) {

            min = Math.min(min,list.get(i));

            ans = Math.max(ans, list.get(i) - min);
        }

        return ans;
    }
}
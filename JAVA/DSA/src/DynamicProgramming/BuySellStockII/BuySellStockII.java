package DynamicProgramming.BuySellStockII;
import java.util.*;
public class BuySellStockII {
    public static int maxProfit(final List<Integer> A) {

        int ans = 0;

        for (int i = 1; i < A.size(); i++) {
            if(A.get(i) > A.get(i-1)) {
                ans += A.get(i) - A.get(i-1);
            }
        }

        return ans;
    }
}
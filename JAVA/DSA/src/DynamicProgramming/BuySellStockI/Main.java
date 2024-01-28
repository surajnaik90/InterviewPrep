package DynamicProgramming.BuySellStockI;

import java.util.*;

public class Main {
    public static void main(String[] args) {

        int ans;
        List<Integer> i1 = new ArrayList<>();
        i1.add(1);i1.add(4);i1.add(5);i1.add(2);i1.add(4);i1.add(8);
        //i1.add(1);i1.add(2);
        ans = BuySellStock.maxProfit(i1);

        System.out.println(ans);

        List<Integer> i2 = new ArrayList<>();
        //i2.add(7);i2.add(4);i2.add(5);i2.add(2);i2.add(28); i2.add(6);
        //ans = BuySellStock.maxProfit(i2);

        //System.out.println(ans);
    }
}
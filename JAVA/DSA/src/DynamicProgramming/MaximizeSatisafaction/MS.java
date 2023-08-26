package DynamicProgramming.MaximizeSatisafaction;

import java.util.ArrayList;

public class MS {
    public static int ans;
    public static int solve(ArrayList<Integer> A) {

        ans = Integer.MIN_VALUE;

        compute(A.size()-1, 0, Integer.MAX_VALUE, A);

        return ans;
    }

    public static void compute(int index, int count, int res, ArrayList<Integer> list) {

        if(index < 0) { return; }

        if(count == 4) {
            ans = Math.max(ans, res);
            return;
        }

        //Pick the element
        int val = res & list.get(index);
        compute(index - 1, count + 1, val, list);

        //Do not pick the element
        compute(index-1, count, res, list);

        return;
    }
}
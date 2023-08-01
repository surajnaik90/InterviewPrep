using System.Runtime.Intrinsics.Arm;

namespace MAANG.AdvancedDSA.DynamicProgramming
{
    public  class _0_1Knapsack
    {
        public static int[,] dp;
        public static int solve(List<int> values, List<int> weights, int capacity)
        {
            dp = new int[values.Count + 1, capacity + 1];

            return maxValues(values.Count - 1, 
                capacity,
                values, weights,capacity);
        }

        public static int maxValues(int n, int w, List<int> v, List<int> wts, int c)
        {
            int tprofit = 0;

            if (n < 0) { return 0; }

            if (dp[n,w] != 0) {
                return dp[n, w];
            }

            //Pick the item
            if ((w - wts[n]) >= 0) {
                tprofit = v[n] + maxValues(n - 1, w - wts[n], v, wts, c);
            }

            //Don't pick the item
            int fprofit = maxValues(n-1, w, v, wts, c);
            
            return dp[n, w] = Math.Max(tprofit, fprofit);
        }
    }
}
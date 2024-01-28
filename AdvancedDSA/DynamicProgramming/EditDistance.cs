using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAANG.AdvancedDSA.DynamicProgramming
{
    public class EditDistance
    {
        public static int[,] dp;
        public static int solve(string A, string B)
        {
            dp = new int[A.Length + 1, B.Length + 1];

            return calculate(A.Length, B.Length, A, B);

        }

        public static int calculate(int m, int n, string A, string B)
        {
            Console.WriteLine("m is " + m + " n is " + n);
            int insertionCost = int.MaxValue, deletionCost = int.MaxValue, replaceCost = int.MaxValue;

            if (m == 0 && n == 0) {
                return 0;
            }

            if (m == 0 && n != 0) {
                return 1 * n;
            }

            if (n == 0 && m != 0) {
                return 1 * m;
            }

            if (A[m-1] == B[n-1]) {
                return calculate(m - 1, n - 1, A, B);
            }

            if (dp[m,n] != 0) {
                return dp[m,n];
            }

            insertionCost = 1 + calculate(m, n - 1 , A, B);

            replaceCost = 1 + calculate(m - 1, n - 1, A, B);

            deletionCost = 1 + calculate(m-1, n, A, B);

            Console.WriteLine("Insertion Cost: " + insertionCost);
            Console.WriteLine("Replace cost: " + replaceCost);
            Console.WriteLine("Deletion cost: " + deletionCost);

            return dp[m,n] = Math.Min(Math.Min(insertionCost, replaceCost), deletionCost);
        }
    }
}

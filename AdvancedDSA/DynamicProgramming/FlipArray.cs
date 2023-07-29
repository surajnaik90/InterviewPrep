/*
 * Given an array A of positive elements, you have to flip the sign of some of its elements such that 
 * the resultant sum of the elements of array should be minimum non-negative(as close to zero as possible).

Return the minimum number of elements whose sign needs to be flipped such that the resultant sum is minimum 
non-negative.

Problem Constraints

1 <= length of(A) <= 100

Sum of all the elements will not exceed 10,000.

Input Format

First and only argument is an integer array A.

Output Format

Return an integer denoting the minimum number of elements whose sign needs to be flipped.

Example Input

Input 1:

 A = [15, 10, 6]
Input 2:

 A = [14, 10, 4]


Example Output

Output 1:

 1
Output 2:

 1

Example Explanation

Explanation 1:

 Here, we will flip the sign of 15 and the resultant sum will be 1.
Explanation 2:

 Here, we will flip the sign of 14 and the resultant sum will be 0.
 Note that flipping the sign of 10 and 4 also gives the resultant sum 0 
but flippings there sign are not minimum.
 */

using System.Linq;

namespace MAANG.AdvancedDSA.DynamicProgramming
{
    public class Pair
    {
        public int sum;
        public int pathCount;
        public int index;
    }
    public class FlipArray
    {
        public static int[,] dp;
        public static int minCount = int.MaxValue;
        public static int minSum = int.MaxValue;
        public static Dictionary<Pair, Pair> dpMap = new Dictionary<Pair, Pair>();
        public static int solve(List<int> A)
        {
            int sum = 0;
            dp = new int[A.Count + 1, 10001];
            for (int i = 0; i <= A.Count; i++) {
                for (int j = 0; j <= 10000; j++) {
                    dp[i, j] = int.MaxValue;
                }
            }

            for (int i = 0; i < A.Count; i++) {
                sum += A[i];
            }

            Pair p = flip3(A.Count - 1, sum, 0, A);

            return p.pathCount;
        }

        public static void flip(int i, int sum, int pathCount, List<int> A) {

            if (i < 0) {
                if (sum < minSum) {
                    minCount = pathCount;
                    minSum = sum;
                    dp[i+1, sum] = pathCount;
                }
                else if (sum == minSum) {
                    if (pathCount < minCount) {
                        minCount = pathCount;
                        dp[i+1, sum] = pathCount;
                    }
                }
                return;
            }

            if (dp[i, sum] != 0) {
                return;
            }

            int newSum = sum - (2 * A[i]);

            //Flip the sign of the element
            if (newSum >= 0) {
                flip(i - 1, newSum, pathCount + 1, A);
            }

            //Do not flip the sign
            flip(i - 1, sum, pathCount, A);

            if(i != -1) {
                dp[i, sum] = minCount;
            }

            return;
        }

        public static void flip2(int i, int sum, int pathCount, List<int> A) {

            //Pair p1 = new Pair();
            //Pair p2 = new Pair();
            //Pair p3, p4, p5 = new Pair(), p6 = new Pair();

            //if (i < 0) {
            //    Pair p = new Pair();
            //    p.sum = sum;
            //    p.pathCount = pathCount;
            //    return p;
            //}            

            //int newSum = sum - (2 * A[i]);

            ////Flip the sign of the element
            //if (newSum >= 0 && ((i-1)) >= 0) {
            //    p1.sum = newSum;
            //    p1.pathCount = pathCount + 1;
            //    p1.element = -A[i];
            //    p3 = flip2(i - 1, newSum, pathCount + 1, A);
            //    p5 = compare(p1, p3);
            //}

            ////Do not flip the sign
            //if((i-1) >= 0) {
            //    p2.sum = sum;
            //    p2.pathCount = pathCount;
            //    p2.element = A[i];
            //    p4 = flip2(i - 1, sum, pathCount, A);
            //    p6 = compare(p2, p4);
            //}

            //return compare(p5, p6);
        }

        public static Pair flip3(int nextElementIndex, int rem_sum, int pathCount, List<int> A)
        {
            Pair flipPair = null, noFlipPair;

            if (nextElementIndex < 0) {
                Pair p = new Pair();
                p.sum = rem_sum;
                p.pathCount = pathCount;
                return p;
            }

            //Pair inputPair = new Pair();
            //inputPair.index = nextElementIndex;
            //inputPair.sum = rem_sum;

            //if (dpMap.ContainsKey(inputPair)) {
            //    return dpMap[inputPair];
            //}

            if (dp[nextElementIndex,rem_sum] != int.MaxValue) {
                return new Pair()
                {
                    pathCount = dp[nextElementIndex,rem_sum]
                };
            }

            //Flip the element
            int newSum = rem_sum - (2 * A[nextElementIndex]);
            if(newSum >= 0) {
                flipPair = flip3(nextElementIndex - 1, newSum, pathCount + 1, A);
            }

            //Do not flip the element
            noFlipPair = flip3(nextElementIndex - 1, rem_sum, pathCount, A);

            Pair res = compare(flipPair, noFlipPair);

            if(res.pathCount < dp[nextElementIndex, rem_sum]) {
                dp[nextElementIndex, rem_sum] = res.pathCount;
            }
            //dpMap.Add(inputPair, res);

            return res;
        }
        public static Pair compare(Pair p1, Pair p2)
        {
            if(p1 == null) {
                return p2;
            }
            else if(p2 == null) {
                return p1;
            }

            if(p1.sum == 0 && p1.pathCount == 0) {
                return p2;
            }
            else if(p2.sum == 0 && p2.pathCount == 0) {
                return p1;
            }

            if (p1.sum < p2.sum) {
                return p1;
            }
            else if (p1.sum > p2.sum) {
                return p2;
            }
            else {
                if (p1.pathCount < p2.pathCount) {
                    return p1;
                }
                else {
                    return p2;
                }
            }
        }
    }
}
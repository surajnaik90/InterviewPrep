﻿/*
Given an integer array A of size N. Find the contiguous subarray within the given array
(containing at least one number) which has the largest product.

Return an integer corresponding to the maximum product possible.

NOTE: Answer will fit in 32-bit integer value.

Problem Constraints
1 <= N <= 5 * 105

-100 <= A[i] <= 100

Input Format
First and only argument is an integer array A.

Output Format
Return an integer corresponding to the maximum product possible.

Example Input
Input 1:

 A = [4, 2, -5, 1]
Input 2:

 A = [-3, 0, -5, 0]

Example Output
Output 1:

 8
Output 2:

 0

Example Explanation
Explanation 1:

 We can choose the subarray [4, 2] such that the maximum product is 8.
Explanation 2:

 0 will be the maximum product possible.
 */

using System.Collections;
using System.Text;

public static class MaxProduct
{
    static int maxProduct;
    public static int solve(List<int> A)
    {
        Dictionary<string, int> dp = new Dictionary<string, int>();
        maxProduct = int.MinValue;

        for (int i = 0; i < A.Count; i++) {
            computeMaxProduct(1, i, Convert.ToString(i), dp, A);
        }

        return maxProduct;
    }

    static void computeMaxProduct(int product, int index, string key,
                            Dictionary<string,int> dp, List<int> A)
    {
        if(index == A.Count) {
            return;
        }

        string dpKey, indexKey = Convert.ToString(index);
        StringBuilder strBuilder = new StringBuilder();

        if(key != indexKey) {
            strBuilder.Append(key); 
            strBuilder.Append(indexKey);
            dpKey = strBuilder.ToString();
        }
        else {
            dpKey = key;
        }

        if(dp.ContainsKey(dpKey)) {
            product *= dp[dpKey];
            maxProduct = Math.Max(maxProduct, product);
        }
        else {
            product *= A[index];
            maxProduct = Math.Max(maxProduct, product);
            dp[dpKey] = product;
            computeMaxProduct(product, index + 1, dpKey, dp, A);
        }

        return;
    }
}
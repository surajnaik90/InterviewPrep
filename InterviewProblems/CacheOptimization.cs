/* CachePtimizationServer problem asked in Amazon on 31-Jul-2022
 * 
 * Similar problem statement:
 * https://leetcode.com/problems/sum-of-total-strength-of-wizards/  
 * 
 * As the ruler of a kingdom, you have an army of wizards at your command.

You are given a 0-indexed integer array strength, where strength[i] denotes the strength of the ith wizard. 
For a contiguous group of wizards (i.e. the wizards' strengths form a subarray of strength), 
the total strength is defined as the product of the following two values:

The strength of the weakest wizard in the group.
The total of all the individual strengths of the wizards in the group.
Return the sum of the total strengths of all contiguous groups of wizards.
Since the answer may be very large, return it modulo 109 + 7.

A subarray is a contiguous non-empty sequence of elements within an array.
 * 
 */
public static class CacheOptimization
{
    public static int solve(int A)
    {
        int power = Convert.ToInt32(Math.Floor(Math.Log2(A)));

        /*int power = 0;int number = A;
        while (number > 1) {
            number /= 2;
            power++;
        }*/

        int diff = Convert.ToInt32(A - Math.Pow(2, power));

        int sum = Convert.ToInt32(Math.Pow(5, power + 1));

        if (diff == 0)
        {
            return sum;
        }
        else
        {
            sum += solve(diff);
        }

        return sum;
    }
}
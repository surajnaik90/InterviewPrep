/*
Given a sorted array of integers (not necessarily distinct) A and an integer B, 
find and return how many pair of integers ( A[i], A[j] ) such that i != j have sum equal to B.

Since the number of such pairs can be very large, return number of such pairs modulo (109 + 7).

Problem Constraints
1 <= |A| <= 100000

1 <= A[i] <= 10^9

1 <= B <= 10^9

Input Format
The first argument given is the integer array A.

The second argument given is integer B.

Output Format
Return the number of pairs for which sum is equal to B modulo (10^9+7).

Example Input
Input 1:

A = [1, 1, 1]
B = 2
Input 2:
 
A = [1, 1]
B = 2

Example Output
Output 1:

 3
Output 2:

 1

Example Explanation
Explanation 1:

 Any two pairs sum up to 2.
Explanation 2:

 only pair (1, 2) sums up to 2.
 */

public static class PairsWithGivenSumII
{
    //This is an optimized approach
    public static int solve(List<int> A, int B)
    {
        long pairsCount = 0, mod = (int)(Math.Pow(10, 9) + 7);        

        int left = 0, right = A.Count - 1;
        long previousLeftPairs = 0, previousRightPairs = 0;
        int previousLeft = -1, previousRight = A.Count - 1;
        long currentPairs = 0;

        while(left != right) {

            if(previousLeft != -1) {
                if (A[left] == A[previousLeft]) {
                    pairsCount = (pairsCount + previousLeftPairs) % mod;
                    previousLeft = left;
                    left++;
                    continue;
                }
                else {
                    previousLeftPairs = 0;
                }
            }

            if (A[right] != A[previousRight] && currentPairs != 0) {
                pairsCount = (pairsCount + currentPairs) % mod;
                previousLeftPairs = currentPairs;
                currentPairs = 0;
            }

            long sum = A[left] + A[right];

            if (sum > B) {
                previousRight = right;
                right--;
            }
            else if (sum < B) {
                previousLeft = left;
                left++;
            }
            else {
                currentPairs++;
                previousRight = right;
                right--;
            }
        }

        pairsCount = (pairsCount + currentPairs) % mod;

        if (previousLeft != -1) {
            if (A[left] == A[previousLeft]) {
                pairsCount = (pairsCount + previousLeftPairs) % mod;
            }
        }
        else {
            previousLeft = left;
            left++;

            while (A[left] == A[previousLeft] && currentPairs != 0) {
                currentPairs--;
                pairsCount = (pairsCount + currentPairs) % mod;
                previousLeft = left;
                left++;

                if(left == A.Count) { break; }
            }
        }

        return Convert.ToInt32(pairsCount);
    }


    //Simpler solution
    public static int solve2(List<int> A, int B)
    {
        int i = 0, j = A.Count - 1, mod = 1000 * 1000 * 1000 + 7;
        long ans = 0;
        while (i < j) {
            if (A[i] + A[j] == B) {
                int ii = i, jj = j;
                if (A[i] == A[j]) {
                    // equal A[i] and A[j]
                    long cnt = j - i + 1;
                    ans += (cnt * (cnt - 1) / 2) % mod;
                    ans %= mod;
                    break;
                }
                else {
                    // count number of elements with value A[i]
                    while (A[i] == A[ii]) {
                        ii++;
                    }
                    int cnt1 = ii - i;
                    i = ii;
                    // count number of elements with value A[j]
                    while (A[jj] == A[j]) {
                        jj--;
                    }
                    int cnt2 = j - jj;
                    j = jj;
                    ans += (cnt1 * cnt2) % mod;
                    ans %= mod;
                }
            }
            else if (A[i] + A[j] > B)
                j--;
            else
                i++;
        }
        return (int)ans;
    }
}
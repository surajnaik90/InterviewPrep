/*
Given a binary string A. It is allowed to do at most one swap between any 0 and 1. 
Find and return the length of the longest consecutive 1’s that can be achieved.

Input Format

The only argument given is string A.
Output Format

Return the length of the longest consecutive 1’s that can be achieved.
Constraints

1 <= length of string <= 1000000
A contains only characters 0 and 1.
For Example

Input 1:
    A = "111000"
Output 1:
    3

Input 2:
    A = "111011101"
Output 2:
    7
 */
public static class LengthofLongestConsecutiveOnes
{
    public static int solve(string A)
    {
        int count = 0, zerosCount=0, maxOnesCount = int.MinValue;

        int firstZeroIndex = -1, secondZeroIndex;

        for (int i = 0; i < A.Length; i++) {

            if (A[i]=='1' && zerosCount<2) {
                count++;
            }
            else if (A[i]=='0') {
                zerosCount++;
            }
            else if (A[i] == '1' && zerosCount>=2) {
                count += 1;
                maxOnesCount = Math.Max(maxOnesCount, count);

                count = 1; zerosCount = 0;
            }
        }

        maxOnesCount = Math.Max(maxOnesCount, count);

        return maxOnesCount;
    }
}
/*
Given two integers A and B, find a number X such that A xor X is minimum possible, and the number of set bits in X equals B.



Problem Constraints
0 <= A <= 109
0 <= B <= 30



Input Format
First argument contains a single integer A. Second argument contains a single integer B.



Output Format
Return a single integer X.



Example Input
Input 1:

 A = 3
 B = 3
Input 2:

 A = 15
 B = 2


Example Output
Output 1:

 7
Output 2:

 12


Example Explanation
Explanation 1:

 3 xor 7 = 4 which is minimum
Explanation 2:

 15 xor 12 = 3 which is minimum
 */
using System.Collections.Generic;

public static class SmallestXOR
{

    public static int solve(int A, int B)
    {
        int[] bitArray = new int[30];


        for (int i = 0; i < 30; i++) {

            if ((A & (1 << i)) > 0) {
                bitArray[i] = 1;
            }
        }

        int count = B;
        int[] newBitArray = new int[30];
        for (int i = bitArray.Count() - 1; i >= 0; i--) {

            if (bitArray[i] == 1 && count > 0) {

                newBitArray[i] = 1;

                count--;
            }
            else {
                if ((i + 1) <= count) {
                    newBitArray[i] = 1;
                }
            }
        }

        int number = 0;
        for (int i = 0; i < 30; i++) {

            if (newBitArray[i] == 1) {
                number += (int)(Math.Pow(2, i));
            }
        }

        return number;
    }
}
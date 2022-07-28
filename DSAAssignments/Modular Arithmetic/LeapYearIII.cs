﻿/*
Given an integer A representing a year, Return 1 if it is a leap year else, return 0.

A year is a leap year if the following conditions are satisfied:

The year is multiple of 400.
Else the year is multiple of 4 and not multiple of 100.


Problem Constraints
1 <= A <= 109

Input Format
First and only argument is an integer A

Output Format
Return 1 if it is a leap year else return 0

Example Input
Input 1

 A = 2020
Input 2:

 A = 1999


Example Output
Output 1

 1
Output 2:

 0

Example Explanation
Explanation 1

 2020 is a leap year.
Explanation 2:

 1999 is not a leap year.
 */

public static class LeapYearIII
{
    public static int Operation1(int A)
    {
        if (A % 400 == 0) {
            return 1;
        }
        else if(A%4==0 && A%100!=0){
            return 1;
        }
        else {
            return 0;
        }
    }
}
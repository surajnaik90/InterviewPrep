package OOPs;

import java.util.Scanner;

/*

Write a program to print the input array A of size N in reverse order where you have to take integer N and further N elements as input from user.


Problem Constraints

1 <= N <= 1000

1 <= A <= 1000
Input Format

A single line representing N followed by N integers of the array A

Output Format

A single line containing N space separated integers representing elements of the input array in reverse order.

Example Input

Input 1:

5 1 2 3 4 5
Input 2:

4 10 50 40 80

Example Output

Output 1:

5 4 3 2 1
Output 2:

80 40 50 10

*/
public class PrintReverse {
    public static void print(){

        Scanner sc = new Scanner(System.in);

        String str = sc.nextLine().trim();
        String[] arrStr = str.split(" ");

        int n = Integer.parseInt(arrStr[0]);

        for (int i = arrStr.length - 1;i > 0; i--) {
            System.out.print(arrStr[i] + " ");
        }
    }
}
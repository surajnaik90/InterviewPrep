package OOPs;

import java.util.Scanner;

/*
Write a program to input N numbers array, a number X and a number Y from user and insert an element Y in it at specified position X. X is based on 1-based indexing

Note: When an element is inserted at position X, all elements that were already present at position >= X, gets shifted to one position right, not replaced.

Problem Constraints

1 <= N <= 100

1 <= A[i] <= 1000

1 <= X <= N

1 <= Y <= 1000

Input Format

First line is N which represents number of elements.

Second line contains N space separated integers.

Third line is X position where Y has to be inserted.

Fourth line is Y which is the value to be inserted.

Output Format

N+1 space separated integers of the input array after inserting the element at required position.

Example Input

Input 1:

5

2 3 1 4 2

3

5

Example Output

Output 1:

2 3 5 1 4 2

Example Explanation

Explanation 1:

Clearly after inserting 5 at 3rd position, new array is 2 3 5 1 4 2.
*/
public class InsertThat {
    public static void print(){

        Scanner sc = new Scanner(System.in);

        int n = Integer.parseInt(sc.nextLine().trim());

        int[] inArr = new int[n+1];
        int[] outArr = new int[n+2];

        String inStr = sc.nextLine().trim();
        String[] inArrayStr = inStr.split(" ");

        for (int i = 1, j = 0; j < inArrayStr.length; i++, j++) {
            inArr[i] = Integer.parseInt(inArrayStr[j]);
        }

        int x = Integer.parseInt(sc.nextLine().trim());
        int y = Integer.parseInt(sc.nextLine().trim());

        boolean isInserted = false;
        for (int i = 1, j = 1; i <= n; i++, j++) {

            if(i == x && !isInserted){
                outArr[j] = y;
                i--; isInserted = true;
                continue;
            }
            outArr[j] = inArr[i];
        }

        for (int i = 1; i < outArr.length; i++) {
            System.out.print(outArr[i]);
            System.out.print(' ');
        }
    }
}
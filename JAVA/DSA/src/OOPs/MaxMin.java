package OOPs;

import java.util.Scanner;

public class MaxMin {

    public static void print(){

        Scanner sc = new Scanner(System.in);

        String inStr = sc.nextLine();

        String[] inArrStr = inStr.split(" ");

        int n = Integer.parseInt(inArrStr[0]);
        int[] arr = new int[n];
        int max = Integer.MIN_VALUE, min = Integer.MAX_VALUE;
        for (int i = 1, j = 0; i < inArrStr.length; i++, j++) {
            arr[j] = Integer.parseInt(inArrStr[i]);
        }

        for (int i = 0; i < arr.length; i++) {
            max = Math.max(max, arr[i]);
            min = Math.min(min, arr[i]);
        }

        System.out.println(max + " " + min);
    }
}
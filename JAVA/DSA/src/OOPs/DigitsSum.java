package OOPs;

import java.util.Scanner;

public class DigitsSum {
    public static void print() {

        Scanner sc = new Scanner(System.in);
        int[] arr = new int[1000];

        int t = Integer.parseInt(sc.nextLine().trim());

        for (int i = 0; i < t; i++) {
            arr[i] = Integer.parseInt(sc.nextLine().trim());
        }

        for (int i = 0; i < arr.length; i++) {

            int sum = 0;

            int num = arr[i];
            while(num > 0) {
                sum += num % 10;
                num = num / 10;
            }

            System.out.println(sum);
        }

    }
}

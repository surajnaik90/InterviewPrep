package OOPs;

import java.util.Scanner;

public class CountDigits {
    public static void print() {

        Scanner sc = new Scanner(System.in);
        int[] arr = new int[1000];

        int t = Integer.parseInt(sc.nextLine().trim());

        for (int i = 0; i < t; i++) {
            arr[i] = Integer.parseInt(sc.nextLine().trim());
        }

        for (int i = 0; i < t; i++) {

            int count = 0;

            int num = arr[i];
            while(num > 0) {
                num = num / 10;
                count++;
            }

            if(arr[i]==0) { count = 1;}
            System.out.println(count);
        }
    }
}

package OOPs;

import java.util.Scanner;
import java.util.*;
public class FirstLast {

    public static void print() {

        Scanner sc = new Scanner(System.in);
        int[] arr = new int[1000];

        int t = Integer.parseInt(sc.nextLine().trim());

        for (int i = 0; i < t; i++) {
            arr[i] = Integer.parseInt(sc.nextLine().trim());
        }

        for (int i = 0; i < arr.length; i++) {

            int lastDigit = arr[i] % 10;
            int firstDigit = 0;

            int num = arr[i];
            while(num > 0) {
                firstDigit = num % 10;
                num = num / 10;
            }

            System.out.println(firstDigit +" " + lastDigit);
        }
        
    }
}

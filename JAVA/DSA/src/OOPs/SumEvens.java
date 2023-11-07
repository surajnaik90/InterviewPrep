package OOPs;

import java.util.Scanner;

public class SumEvens {

    public static void printSum(){

        Scanner sc = new Scanner(System.in);

        int n = Integer.parseInt(sc.nextLine().trim());

        long sum = 0;
        for (int i = 2; i <=n; i++) {

            if(i % 2 == 0) {
                sum += i;
            }
        }

        System.out.println(sum);
    }
}
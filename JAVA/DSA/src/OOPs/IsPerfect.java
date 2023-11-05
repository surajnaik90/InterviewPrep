package OOPs;

import java.util.Scanner;

public class IsPerfect {

    public static void isPerfect(){

        Scanner sc = new Scanner(System.in);

        long t = Long.parseLong(sc.nextLine().trim());

        for (long i = 0; i < t; i++) {

            long n = Long.parseLong(sc.nextLine().trim());

            long sum = 0, j = 1;
            while(j < n) {

                if(n % j == 0) {
                    sum += j;
                }
                j++;
            }

            if(sum == n) {
                System.out.println("YES");
            }
            else {
                System.out.println("NO");
            }
        }
    }
}
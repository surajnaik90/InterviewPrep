package OOPs;

import java.util.Scanner;

public class CountFactors {
    public static void print() {

        Scanner sc = new Scanner(System.in);

        int n = Integer.parseInt(sc.nextLine().trim());


        int count = 0;
        for (int i = 1; i <= n; i++) {

            if(n%i==0){
                count++;
            }
        }

        System.out.println(count);
    }
}

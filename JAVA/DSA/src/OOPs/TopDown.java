package OOPs;

import java.util.Scanner;

public class TopDown {

    public static void print(){

        Scanner sc = new Scanner(System.in);

        int a = Integer.parseInt(sc.nextLine().trim());

        int sum = (a * (a+1)) / 2;
        System.out.print(sum);

        for (int i = 1; i <= a; i++) {

            if(i%2!=0) {
                System.out.print(i + " ");
            }
        }

    }
}

package OOPs;

import java.util.Scanner;

public class InvertedPyramid {
    public static void print(){

        Scanner sc = new Scanner(System.in);

        int n = Integer.parseInt(sc.nextLine().trim());

        for (int i = n; i >= 1; i--) {

            for (int j = 1; j <= n; j++) {

                if(j < i) {
                    System.out.print(j);
                    System.out.print(' ');

                }
                if(j == i){
                    System.out.print(j);
                }
            }
            System.out.println();
        }
    }
}

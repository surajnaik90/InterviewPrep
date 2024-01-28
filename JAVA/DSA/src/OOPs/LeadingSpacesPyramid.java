package OOPs;

import java.util.Scanner;

public class LeadingSpacesPyramid {
    public static void print(){

        Scanner sc = new Scanner(System.in);

        int n = Integer.parseInt(sc.nextLine().trim());

        for (int i = 1; i <= n; i++) {

            for (int j = n; j >= 1; j--) {

                if(j > i) {
                    System.out.print(' ');
                }
                else {
                    System.out.print('*');
                }
            }
            System.out.println("");
        }
    }
}

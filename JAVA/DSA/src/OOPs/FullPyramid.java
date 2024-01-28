package OOPs;

import java.util.Scanner;

public class FullPyramid {
    public static void print() {

        Scanner sc = new Scanner(System.in);

        int n = Integer.parseInt(sc.nextLine().trim());
        int columnCount = (2 * n) - 1, spaceCount = n - 1;

        for (int i = 1; i <= n; i++) {

            int count = spaceCount;

            while(count > 0) {
                System.out.print(' ');
                count--;
            }

            for (int j = 1; j <= i; j++) {

                System.out.print('*');
                System.out.print(' ');
            }
            System.out.println("");
            spaceCount--;
        }
    }
}
package OOPs;

import java.util.Scanner;

public class HollowInverted {
    public static void print(){

        Scanner sc = new Scanner(System.in);

        int n = Integer.parseInt(sc.nextLine().trim());
        int colLength = 2 * n;

        for (int i = 1; i <= n; i++) {

            int spacesCount = colLength - (2*i);
            for (int j = 1; j <= colLength; j++) {

                if(j <= i) {
                    System.out.print('*');
                    continue;
                }
                if(spacesCount > 0) {
                    System.out.print(' ');
                    spacesCount--;
                    continue;
                }
                System.out.print('*');
            }
            System.out.println("");
        }
    }
}

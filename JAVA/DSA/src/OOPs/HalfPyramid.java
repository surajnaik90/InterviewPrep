package OOPs;

import java.util.Scanner;

public class HalfPyramid {
    public static void halfPyramid(){

        Scanner sc = new Scanner(System.in);

        int n = Integer.parseInt(sc.nextLine().trim());

        for (int i = 1; i <= n; i++) {

            for (int j = 1; j <= n; j++) {

                if(j <= i) {
                    if(j % 2 != 0){
                        System.out.print(j);
                    }
                    else {
                        System.out.print(' ');
                    }
                }

            }
            System.out.println("");
        }
    }
}

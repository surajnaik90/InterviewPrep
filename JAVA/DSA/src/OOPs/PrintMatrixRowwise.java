package OOPs;

import java.util.Scanner;

public class PrintMatrixRowwise {

    public static void print(){

        Scanner sc = new Scanner(System.in);

        String rc = sc.nextLine();
        int rows = Integer.parseInt(rc.split(" ")[0]);
        int columns = Integer.parseInt(rc.split(" ")[1]);

        int[][] matrix = new int[rows][columns];
        for (int i = 0; i < rows; i++) {

            String str = sc.nextLine().trim();
            String[] arrStr = str.split(" ");

            for (int j = 0; j < arrStr.length; j++) {
                matrix[i][j] = Integer.parseInt(arrStr[j]);
            }
        }

        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                System.out.print(matrix[i][j]);
                System.out.print(" ");
            }
            System.out.println();
        }
    }
}

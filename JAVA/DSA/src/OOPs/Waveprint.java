package OOPs;

import java.util.Scanner;

public class Waveprint {
    public static void print(){

        Scanner sc = new Scanner(System.in);

        int n = Integer.parseInt(sc.nextLine().trim());
        int[][] matrix = new int[n][n];
        int[] outArr = new int[n*n];

        for (int i = 0; i < n; i++) {

            String row = sc.nextLine().trim();
            String[] rowNos = row.split(" ");

            for (int j = 0; j < rowNos.length; j++) {
                matrix[i][j] = Integer.parseInt(rowNos[j]);
            }
        }

        int k = 0;
        for (int j = 0; j < n; j++) {

            if(j % 2 == 0) {
                for (int i = 0; i < n; i++) {
                    outArr[k++] = matrix[i][j];
                }
            }
            else {
                for (int i = n - 1; i >= 0; i--) {
                    outArr[k++] = matrix[i][j];
                }
            }
        }

        for (int i = 0; i < outArr.length; i++) {
            System.out.print(outArr[i] + " ");
        }
    }
}

package OOPs;

import java.util.Scanner;

public class SumArray {
    public static void print() {

        Scanner sc = new Scanner(System.in);

        String str = sc.nextLine().trim();
        String[] arrStr = str.split(" ");

        int n = Integer.parseInt(arrStr[0]);

        int sum = 0;
        for (int i = 1; i < arrStr.length; i++) {
            sum += Integer.parseInt(arrStr[i]);
        }

        System.out.println(sum);
    }
}

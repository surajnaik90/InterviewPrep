package OOPs.Strings;

import java.util.Scanner;

public class Length {
    public static void print(){

        Scanner sc = new Scanner(System.in);

        int t = Integer.parseInt(sc.nextLine().trim());
        String[] arrStr = new String[t];
        for (int i = 0; i < t; i++) {
            arrStr[i] = sc.nextLine().trim();
        }

        for (int i = 0; i < arrStr.length; i++) {
            System.out.println(arrStr[i].length());
        }
    }
}

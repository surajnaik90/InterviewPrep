package OOPs;

import java.util.Scanner;

public class IsPrime {

    public static String isPrime(int no){

        Scanner sc = new Scanner(System.in);

        int n = Integer.parseInt(sc.nextLine().trim());

        for (int i = 2; i <= 1000000; i++) {

            if(i==n) { continue; }

            if(n%i == 0) {
                return "No";
            }
        }

        return "YES";
    }
}

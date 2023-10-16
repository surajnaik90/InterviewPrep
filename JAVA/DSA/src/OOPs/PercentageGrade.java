package OOPs;

import java.util.Scanner;

public class PercentageGrade {

    public static void print(){

        Scanner sc = new Scanner(System.in);

        int A = Integer.parseInt(sc.nextLine());
        int B = Integer.parseInt(sc.nextLine());
        int C = Integer.parseInt(sc.nextLine());
        int D = Integer.parseInt(sc.nextLine());
        int E = Integer.parseInt(sc.nextLine());

        int avg = (A+B+C+D+E) / 5;
        System.out.println(avg);

        if(avg >= 90) {
            System.out.println("A");
        }
        else if(avg >= 80 && avg < 90) {
            System.out.println("B");
        }
        else if(avg >= 70 && avg < 80) {
            System.out.println("C");
        }
        else if(avg >= 60 && avg < 70) {
            System.out.println("D");
        }
        else if(avg >= 40 && avg < 60) {
            System.out.println("E");
        }
        else {
            System.out.println("F");
        }
    }
}

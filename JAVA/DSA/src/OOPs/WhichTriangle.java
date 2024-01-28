package OOPs;

import java.util.Scanner;

public class WhichTriangle {
    public static void print() {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();
        String[] numbers = input.split(" ");

        int A = Integer.parseInt(numbers[0]);
        int B = Integer.parseInt(numbers[1]);
        int C = Integer.parseInt(numbers[2]);

        if(A == B && B == C) {
            System.out.println("equilateral");
        }
        else if(A == B || B == C || A == C) {
            System.out.println("isosceles");
        }
        else {
            System.out.println("scalene");
        }
    }
}